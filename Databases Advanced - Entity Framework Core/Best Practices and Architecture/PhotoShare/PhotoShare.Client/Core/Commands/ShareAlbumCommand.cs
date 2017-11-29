namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Models.Enumerations;
    using PhotoShare.Services.Interfaces;

    public class ShareAlbumCommand : AlbumSettingsCommand
    {
        private const string AlbumNotFoundExceptionMessage = "Album {0} not found!";
        private const string UserNotFoundExceptionMessage = "User {0} not found!";
        private const string InvalidRoleExceptionMessage = "Permission must be either “Owner” or “Viewer”!";

        private const string SuccessfulSharedAlbum = "Username {0} added to album {1} ({2})";

        public ShareAlbumCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public override string Execute(string[] data)
        {
            var album = this.GetAlbumById(int.Parse(data[0]));
            this.VerifyOwnerPermissions(album);
            var user = this.GetUserByUsername(data[1]);
            var permission = this.ParsePermission(data[2]);

            this.Context.AlbumRoles.Add(new AlbumRole(user, album, permission));
            this.Context.SaveChanges();

            return string.Format(SuccessfulSharedAlbum, user.Username, album.Name, permission.ToString());
        }

        private Role ParsePermission(string name)
        {
            Role role;
            var isRoleValid = Enum.TryParse(name, true, out role);
            if (!isRoleValid)
            {
                throw new ArgumentException(InvalidRoleExceptionMessage);
            }

            return role;
        }

        private User GetUserByUsername(string username)
        {
            var user = this.Context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExceptionMessage, username));
            }

            return user;
        }

        private Album GetAlbumById(int id)
        {
            var album = this.Context.Albums
                .SingleOrDefault(a => a.Id == id);

            if (album == null)
            {
                throw new ArgumentException(string.Format(AlbumNotFoundExceptionMessage, id));
            }

            return album;
        }
    }
}
