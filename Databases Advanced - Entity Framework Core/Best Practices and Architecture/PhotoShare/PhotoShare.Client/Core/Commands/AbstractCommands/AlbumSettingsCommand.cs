namespace PhotoShare.Client.Core.Commands.AbstractCommands
{
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Models.Enumerations;
    using PhotoShare.Services.Interfaces;
    using System;
    using System.Linq;

    public abstract class AlbumSettingsCommand : ICommand
    {
        private const string UnallowedAccessExceptionMessage = "Only owners of the album can perform this operation!";

        private PhotoShareContext context;
        private IUserSessionService userSession;

        protected AlbumSettingsCommand(PhotoShareContext context, IUserSessionService userSession)
        {
            this.Context = context;
            this.UserSession = userSession;
        }

        protected PhotoShareContext Context { get => context; set => context = value; }

        protected IUserSessionService UserSession { get => userSession; set => userSession = value; }

        public void VerifyOwnerPermissions(Album album)
        {
            this.userSession.Authorize();

            var isUserOwner = this.context.AlbumRoles
                .Where(ar => ar.Album.Id == album.Id && ar.User.Id == this.userSession.User.Id)
                .Any(ar => ar.Role == Role.Owner);

            if (!isUserOwner)
            {
                throw new InvalidOperationException(UnallowedAccessExceptionMessage);
            }
        }

        public abstract string Execute(string[] data);
    }
}
