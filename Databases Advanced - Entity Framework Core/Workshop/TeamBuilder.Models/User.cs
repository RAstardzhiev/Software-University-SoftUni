namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using TeamBuilder.Models.Enumerations;
    using TeamBuilder.Models.Helpers;

    public class User
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private int? age;

        public User()
        {
            this.Events = new HashSet<Event>();
            this.Invitations = new HashSet<Invitation>();
            this.UserTeams = new HashSet<UserTeam>();
            this.CreatedTeams = new HashSet<Team>();
        }

        public int Id { get; set; }

        public string Username
        {
            get => this.username;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.UsernameMinLength,
                    Constants.UsernameMaxLength,
                    nameof(this.Username));

                this.username = value;
            }
        }

        public string FirstName
        {
            get => this.firstName;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.DefaultStringMinLength,
                    Constants.UserFirstNameMaxLength,
                    nameof(this.FirstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.DefaultStringMinLength,
                    Constants.UserLastNameMaxLength,
                    nameof(this.LastName));

                this.lastName = value;
            }
        }

        public string Password
        {
            get => this.password;

            set
            {
                Validator.StringContainsValidation(value,
                    Constants.PasswordMissingDigitExceptionMessage,
                    ch => char.IsDigit(ch));

                Validator.StringContainsValidation(value,
                    Constants.PasswordMissingUpperCaseExceptionMessage,
                    ch => char.IsUpper(ch));

                Validator.StringLengthValidation(value,
                    Constants.PasswordMinLength,
                    Constants.PasswordMaxLength,
                    nameof(this.Password));

                this.password = value;
            }
        }

        public Gender? Gender { get; set; }

        public int? Age
        {
            get => this.age;

            set
            {
                Validator.IntegerRangeValidation(value, nameof(this.Age), 
                    Constants.UserAgeMinLength, 
                    Constants.UserAgeMaxLength);

                this.age = value;
            }
        }

        public bool? IsDeleted { get; set; }

        public ICollection<Event> Events { get; set; }

        public ICollection<Invitation> Invitations { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }

        public ICollection<Team> CreatedTeams { get; set; }
    }
}
