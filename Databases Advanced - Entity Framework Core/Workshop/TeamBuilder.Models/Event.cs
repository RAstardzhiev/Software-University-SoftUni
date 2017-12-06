namespace TeamBuilder.Models
{
    using System;
    using System.Collections.Generic;
    using TeamBuilder.Models.Helpers;

    public class Event
    {
        private string name;
        private string description;
        private DateTime? endDate;

        public Event()
        {
            this.EventTeams = new HashSet<TeamEvent>();
        }

        public int Id { get; set; }

        public string Name
        {
            get => this.name;

            set
            {
                Validator.StringLengthValidation(value,
                    Constants.DefaultStringMinLength,
                    Constants.EventNameMaxLength,
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
                    Constants.EventDescriptionMaxLength,
                    nameof(this.Description));

                this.description = value;
            }
        }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate
        {
            get => this.endDate;

            set
            {
                if (this.StartDate == null || this.StartDate > value)
                {
                    throw new ArgumentException(Constants.StartDateErrorExceptionMessage);
                }

                this.endDate = value;
            }
        }

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<TeamEvent> EventTeams { get; set; }
    }
}
