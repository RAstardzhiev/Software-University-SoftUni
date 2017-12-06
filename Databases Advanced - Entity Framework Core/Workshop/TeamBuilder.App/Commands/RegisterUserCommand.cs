namespace TeamBuilder.App.Commands
{
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Enumerations;

    public class RegisterUserCommand : Command
    {
        private const int ArgsExactLength = 7;
        private const string Success = "User {0} was registered successfully!";

        private const string UsernameTakenExceptionMessage = "Username {0} is already taken!";
        private const string PasswordsDoNotMatchExceptionMessage = "Passwords do not match!";
        private const string GenderNotValidExceptionMessage = "Gender should be either “Male” or “Female”!";
        private const string LogoutFirstExceptionMessage = "You should logout first!";
        private const string UsernameNotValidExceptionMessage = "Username {0} not valid!";
        private const string PasswordNotValidExceptionMessage = "Password {0} is not valid!";
        private const string AgeNotValidExceptionMessage = "Age not valid!";
        
        public RegisterUserCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <username> <password> <repeat-password> <firstName> <lastName> <age> <gender>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedOut();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var username = this.CmdArgs[0];
            var password = this.CmdArgs[1];
            var repeatPassword = this.CmdArgs[2];
            var firstName = this.CmdArgs[3];
            var lastName = this.CmdArgs[4];
            var age = int.Parse(this.CmdArgs[5]);

            Gender gender;
            var isGenderValid = Enum.TryParse(this.CmdArgs[6], out gender);
            if (!isGenderValid)
            {
                throw new ArgumentException(GenderNotValidExceptionMessage);
            }

            if (password != repeatPassword)
            {
                throw new InvalidOperationException(PasswordsDoNotMatchExceptionMessage);
            }

            var user = this.GetUser(context, username, password, firstName, lastName, age);

            context.Users.Add(user);
            context.SaveChanges();

            this.Session.LogIn(user);

            return string.Format(Success, username);
        }

        private User GetUser(TeamBuilderContext context, string username, string password, string firstName, string lastName, int age)
        {
            var user = context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user != null && user.IsDeleted != false)
            {
                throw new InvalidOperationException(string.Format(UsernameTakenExceptionMessage, username));
            }

            user = new User();
            base.AssignValueArgument<User>(user, string.Format(UsernameNotValidExceptionMessage, username), u => u.Username = username);
            base.AssignValueArgument<User>(user, string.Format(PasswordNotValidExceptionMessage, password), u => u.Password = password);
            base.AssignValueArgument<User>(user, AgeNotValidExceptionMessage, u => u.Age = age);
            user.FirstName = firstName;
            user.LastName = lastName;

            return user;
        }
    }
}
