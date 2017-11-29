namespace PhotoShare.Client.Core.Commands
{
    using System;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Services.Interfaces;

    public class LoginCommand : ICommand
    {
        private const string DeletedUserExceptionMessage = "Invalid username or password!";
        private const string MultipleLoginExceptionMessage = "You are already logged in as {0}!";

        private const string SuccessfulLogIn = "User {0} successfully logged in!";

        private IUserSessionService userSession;

        public LoginCommand(IUserSessionService userSession)
        {
            this.userSession = userSession;
        }

        // Login <username> <password>
        public string Execute(string[] data)
        {
            var username = data[0];
            var password = data[1];

            if (this.userSession.User != null && 
                this.userSession.User.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(string.Format(MultipleLoginExceptionMessage, username));
            }

            var user = this.userSession.Login(username, password);
            if (user.IsDeleted.Value)
            {
                this.userSession.Logout();
                throw new InvalidOperationException(DeletedUserExceptionMessage);
            }

            return string.Format(SuccessfulLogIn, username);
        }
    }
}
