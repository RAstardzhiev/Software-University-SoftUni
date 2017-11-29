namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Services.Interfaces;

    public class DeleteUserCommand : UserSettingsCommand
    {
        private const string UserNotFoundExceptionMessage = "User {0} not found!";
        private const string UserAlreadyDeletedExceptionMessage = "User {0} is already deleted!";

        private const string SuccessfulDeletion = "User {0} was deleted successfully!";

        public DeleteUserCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }
        
        // DeleteUser <username>
        public override string Execute(string[] data)
        {
            string username = data[0];

            var user = this.Context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new InvalidOperationException(string.Format(UserNotFoundExceptionMessage, username));
            }

            if (user.IsDeleted.Value)
            {
                throw new InvalidOperationException(string.Format(UserAlreadyDeletedExceptionMessage, username));
            }

            this.ProfileOwnerVerification(user);

            user.IsDeleted = true;
            this.Context.SaveChanges();

            this.UserSession.Logout();
            return string.Format(SuccessfulDeletion, username);
        }
    }
}
