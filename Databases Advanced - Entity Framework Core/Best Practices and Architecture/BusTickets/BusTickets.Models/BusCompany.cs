namespace BusTickets.Models
{
    using System;
    using System.Collections.Generic;

    public class BusCompany
    {
        public const byte MinRating = 1;
        public const byte MaxRating = 10;

        private readonly string InvalidRatingExceptionMessage = $"Rating must be between {MinRating} and {MaxRating}";

        private double? rating;

        private BusCompany()
        {
            this.Trips = new HashSet<Trip>();
            this.Reviews = new HashSet<Review>();
        }

        public BusCompany(string name, Country country)
            :this()
        {
            this.Name = name;
            this.Country = country;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double? Rating
        {
            get => this.rating;

            set
            {
                if (value < MinRating || value > MaxRating)
                {
                    throw new ArgumentException(InvalidRatingExceptionMessage);
                }

                this.rating = value;
            }
        }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Trip> Trips { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
