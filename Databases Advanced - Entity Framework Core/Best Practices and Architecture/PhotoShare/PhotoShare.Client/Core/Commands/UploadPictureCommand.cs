namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Interfaces;

    public class UploadPictureCommand : AlbumSettingsCommand
    {
        private const string AlbumNotFoundExceptionMessage = "Album {0} not found!";

        private const string SuccessfulAddedPicture = "Picture {0} added to {1}!";

        public UploadPictureCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public override string Execute(string[] data)
        {
            var album = this.GetAlbumByName(data[0]);
            var title = data[1];
            var path = data[2];

            this.Context.Pictures.Add(new Picture(title, path, album));
            this.Context.SaveChanges();

            return string.Format(SuccessfulAddedPicture, title, album.Name);
        }

        private Album GetAlbumByName(string name)
        {
            var album = this.Context.Albums
                .SingleOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (album == null)
            {
                throw new ArgumentException(string.Format(AlbumNotFoundExceptionMessage, name));
            }

            this.VerifyOwnerPermissions(album);
            return album;
        }
    }
}
