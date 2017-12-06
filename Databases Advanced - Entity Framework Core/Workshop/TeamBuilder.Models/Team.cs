namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using TeamBuilder.Models.Helpers;

    public class Team
    {
        private string name;
        private string description;
        private string acronym;

        public Team()
        {
            this.Invitations = new HashSet<Invitation>();
            this.TeamUsers = new HashSet<UserTeam>();
            this.TeamEvents = new HashSet<TeamEvent>();
        }

        public int Id { get; set; }

        public string Name
        {
            get => this.name;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.DefaultStringMinLength,
                    Constants.TeamNameMaxLength,
                    nameof(this.Name));

                this.name = value;
            }
        }

        public string Description
        {
            get => this.description;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.DefaultStringMinLength,
                    Constants.TeamDescriptionMaxLength,
                    nameof(this.description));

                this.description = value;
            }
        }

        public string Acronym
        {
            get => this.acronym;

            set
            {
                Validator.StringLengthValidation(value, 
                    Constants.TeamAcronymExactLength,
                    Constants.TeamAcronymExactLength, 
                    nameof(this.Acronym));

                this.acronym = value;
            }
        }

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<Invitation> Invitations { get; set; }

        public ICollection<UserTeam> TeamUsers { get; set; }

        public ICollection<TeamEvent> TeamEvents { get; set; }
    }
}
