namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Models.Enumerations;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Services.Interfaces;

    public class CreateAlbumCommand : ICommand
    {
        private const string UnexistingUserExceptionMessage = "User {0} not found!";
        private const string AlbumExistsExceptionMessage = "Album {0} exists!";
        private const string ColorNotExistsExceptionMessage = "Color {0} not found!";
        private const string MissingTagsExceptionMessage = "Invalid tags!";
        private const string WrongUserArgExceptionMessage = "You can not create an album on behalf of another user!";

        private const string SuccessAddition = "Album {0} successfully created!";
        private const bool DefaultIsPubluc = true;
        private const Role UserRole = Role.Owner;

        private PhotoShareContext context;
        private IUserSessionService userSession;

        public CreateAlbumCommand(PhotoShareContext context, IUserSessionService userSession)
        {
            this.context = context;
            this.userSession = userSession;
        }

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            var user = this.GetUser(data[0]);
            var albumTitle = data[1];
            this.CheckIfAlbumIsPresent(albumTitle);
            var BgColor = this.ParseColor(data[2]);
            var tags = this.GetTags(data
                .Skip(3)
                .Select(t => t.StartsWith('#') ? t : $"#{t}")
                .ToArray());

            var album = new Album(albumTitle, DefaultIsPubluc);
            album.BackgroundColor = BgColor;
            user.AlbumRoles.Add(new AlbumRole(user, album, UserRole));
            foreach (var tag in tags)
            {
                this.context.AlbumTags.Add(new AlbumTag(album, tag));
            }

            this.context.SaveChanges();
            return string.Format(SuccessAddition, albumTitle);
        }

        private Color ParseColor(string BgColor)
        {
            Color color;
            var isColorAvailable = Enum.TryParse(BgColor, true, out color);
            if (!isColorAvailable)
            {
                throw new ArgumentException(string.Format(ColorNotExistsExceptionMessage, BgColor));
            }

            return color;
        }

        private void CheckIfAlbumIsPresent(string albumTitle)
        {
            var album = this.context.Albums
                .SingleOrDefault(a => a.Name.Equals(albumTitle, StringComparison.OrdinalIgnoreCase));

            if (album != null)
            {
                throw new ArgumentException(string.Format(AlbumExistsExceptionMessage, albumTitle));
            }
        }

        private User GetUser(string username)
        {
            var user = this.context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UnexistingUserExceptionMessage, username));
            }

            if (this.userSession.User.Id != user.Id)
            {
                throw new ArgumentException(WrongUserArgExceptionMessage);
            }

            return user;
        }

        private Tag[] GetTags(string[] tagNames)
        {
            if (tagNames.Length < 1)
            {
                throw new ArgumentException(MissingTagsExceptionMessage);
            }

            var tags = new Tag[tagNames.Length];

            for (int i = 0; i < tagNames.Length; i++)
            {
                var currentTag = this.context.Tags
                    .SingleOrDefault(t => t.Name.Equals(tagNames[i], StringComparison.OrdinalIgnoreCase));

                if (currentTag == null)
                {
                    currentTag = new Tag(tagNames[i]);
                }

                tags[i] = currentTag;
            }

            return tags;
        }
    }
}
