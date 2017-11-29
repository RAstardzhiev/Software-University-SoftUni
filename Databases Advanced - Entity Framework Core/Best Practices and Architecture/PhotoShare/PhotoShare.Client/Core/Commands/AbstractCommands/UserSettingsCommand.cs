namespace PhotoShare.Client.Core.Commands.AbstractCommands
{
    using System;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Interfaces;

    public abstract class UserSettingsCommand : ICommand
    {
        private const string UnallowedAccessExceptionMessage = "You are not allowed to perform this action";

        private PhotoShareContext context;
        private IUserSessionService userSession;

        protected UserSettingsCommand(PhotoShareContext context, IUserSessionService userSession)
        {
            this.Context = context;
            this.UserSession = userSession;
        }

        protected PhotoShareContext Context { get => context; set => context = value; }

        protected IUserSessionService UserSession { get => userSession; set => userSession = value; }

        public void ProfileOwnerVerification(User user)
        {
            var isProfileOwner = this.userSession.User?.Id == user.Id;
            if (!isProfileOwner)
            {
                throw new InvalidOperationException(UnallowedAccessExceptionMessage);
            }
        }

        public abstract string Execute(string[] data);
    }
}
