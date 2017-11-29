namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Services.Interfaces;

    public class RegisterUserCommand : ICommand
    {
        private const string PasswordNotMatchedExceptionMessage = "Passwords do not match!";
        private const string UsernameTakenExceptionMessage = "Username {0} is already taken!";
        private const string InvalidParametersExceptionMessage = "Invalid command parameters";
        private const string AlreadyLoggedInExceptionMessage = "You should logout first!";

        private const string SuccessfulRegistrationMessage = "User {0} was registered successfully!";

        private PhotoShareContext context;
        private IUserSessionService userSession;

        public RegisterUserCommand(PhotoShareContext context, IUserSessionService userSession) 
        {
            this.userSession = userSession;
            this.context = context;
        }

        // RegisterUser <username> <password> <repeat-password> <email>
        public string Execute(string[] data)
        {
            if (data.Length != 4)
            {
                throw new ArgumentException(InvalidParametersExceptionMessage);
            }
            else if (this.userSession.User != null)
            {
                throw new InvalidOperationException(AlreadyLoggedInExceptionMessage);
            }

            string username = data[0];
            string password = data[1];
            string repeatPassword = data[2];
            string email = data[3];

            var user = this.context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                throw new InvalidOperationException(string.Format(UsernameTakenExceptionMessage, username));
            }
            else if (password != repeatPassword)
            {
                throw new ArgumentException(PasswordNotMatchedExceptionMessage);
            }

            user = new User(username, password, email);
            user.IsDeleted = false;
            user.RegisteredOn = DateTime.Now;
            user.LastTimeLoggedIn = DateTime.Now;

            this.context.Users.Add(user);
            this.context.SaveChanges();

            this.userSession.Login(username, password);
            return string.Format(SuccessfulRegistrationMessage, user.Username);
        }
    }
}
