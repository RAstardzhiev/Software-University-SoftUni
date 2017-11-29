namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Interfaces;

    public class AddTagToCommand : AlbumSettingsCommand
    {
        private const string UnexistentArgsExceptionMessage = "Either tag or album do not exist!";

        private const string SuccessfulAddition = "Tag {0} added to {1}!";

        public AddTagToCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // AddTagTo <albumName> <tag>
        public override string Execute(string[] data)
        {
            var album = this.GetAlbum(data[0]);
            this.VerifyOwnerPermissions(album);
            var tag = this.GetTag(data[1]);

            this.Context.Add(new AlbumTag(album, tag));
            this.Context.SaveChanges();

            return string.Format(SuccessfulAddition, tag.Name, album.Name);
        }

        private Tag GetTag(string tagName)
        {
            if (!tagName.StartsWith('#'))
            {
                tagName = $"#{tagName}";
            }

            var tag = this.Context.Tags
                .SingleOrDefault(t => t.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));

            if (tag == null)
            {
                throw new ArgumentException(UnexistentArgsExceptionMessage);
            }

            return tag;
        }

        private Album GetAlbum(string albumName)
        {
            var album = this.Context.Albums
                .SingleOrDefault(a => a.Name.Equals(albumName, StringComparison.OrdinalIgnoreCase));

            if (album == null)
            {
                throw new ArgumentException(UnexistentArgsExceptionMessage);
            }

            return album;
        }
    }
}
