namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Client.Core.Commands.AbstractCommands;
    using PhotoShare.Services.Interfaces;

    public class ModifyUserCommand : UserSettingsCommand
    {
        private const string UserNotFoundExceptionMessage = "User {0} not found!";
        private const string ForbiddenOrNotSupportedModificationExceptionMessage = "Property {0} not supported!";
        private readonly string ValueNotValidExceptionMessage = "Value {0} not valid." + Environment.NewLine + "{1}";

        private const string SuccessfulModiffication = "User {0} {1} is {2}.";

        public ModifyUserCommand(PhotoShareContext context, IUserSessionService userSession) 
            : base(context, userSession)
        {
        }

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public override string Execute(string[] data)
        {
            var username = data[0];
            var property = data[1];
            var newValue = data[2];

            var user = this.Context.Users
                .SingleOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                throw new ArgumentException(string.Format(UserNotFoundExceptionMessage, username));
            }

            if (user.IsDeleted.Value)
            {
                throw new InvalidOperationException(string.Format(UserNotFoundExceptionMessage, username));
            }

            this.ProfileOwnerVerification(user);
            this.PerformModification(property, user, newValue);

            return string.Format(SuccessfulModiffication, username, property, newValue);
        }

        private void PerformModification(string property, User user, string newValue)
        {
            switch (property.ToLower())
            {
                case "password":
                    this.ChangePassword(user, newValue);
                    break;
                case "borntown":
                    user.BornTown = this.GetTown(newValue);
                    break;
                case "currenttown":
                    user.CurrentTown = this.GetTown(newValue);
                    break;
                default:
                    throw new ArgumentException(string.Format(ForbiddenOrNotSupportedModificationExceptionMessage, property));
            }

            this.Context.SaveChanges();
        }

        private void ChangePassword(User user, string newValue)
        {
            try
            {
                user.Password = newValue;
            }
            catch (ValidationException ve)
            {
                var message = string.Concat(string.Format(ValueNotValidExceptionMessage, newValue, ve.Message), 
                    Environment.NewLine,
                    ve?.InnerException?.Message ?? string.Empty);

                throw new ArgumentException(message);
            }
        }

        private Town GetTown(string name)
        {
            var town = this.Context.Towns
                .SingleOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (town == null)
            {
                town = new Town(name);
            }

            return town;
        }
    }
}
