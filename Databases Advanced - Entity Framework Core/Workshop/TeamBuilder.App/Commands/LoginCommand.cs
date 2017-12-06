namespace TeamBuilder.App.Commands
{
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public class LoginCommand : Command
    {
        private const string Success = "User {0} successfully logged in!";
        private const int ArgsExactLength = 2;

        private const string InvalidLoginExceptionMessage = "Invalid username or password!";

        public LoginCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <username> <password>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedOut();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var username = this.CmdArgs[0];
            var password = this.CmdArgs[1];

            var user = context.Users
                .SingleOrDefault(u =>
                    u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    u.Password.Equals(password));

            if (user == null || user.IsDeleted == true)
            {
                throw new ArgumentException(InvalidLoginExceptionMessage);
            }

            this.Session.LogIn(user);

            return string.Format(Success, username);
        }
    }
}
