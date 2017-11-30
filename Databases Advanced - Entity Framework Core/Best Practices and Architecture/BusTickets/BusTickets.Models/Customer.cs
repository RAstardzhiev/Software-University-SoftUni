namespace BusTickets.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer
    {
        private const string InvalidGenderExceptionMessages = "Invalid gender: the only possible genders are M (male) and F (female)";
        private readonly string[] PossibleGenders = { "M", "F" };

        private string gender;

        private Customer()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Reviews = new HashSet<Review>();
            this.BankAccounts = new HashSet<BankAccount>();
        }

        public Customer(string firstName, string lastName, Town homeTown)
            :this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HomeTown = homeTown;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender // EF Core Doesn't support conversion from CHAR properties
        {
            get => this.gender;

            set
            {
                if (!PossibleGenders.Any(g => g == value.ToUpper()))
                {
                    throw new ArgumentException(InvalidGenderExceptionMessages);
                }

                this.gender = value;
            }
        }

        public int HomeTownId { get; set; }
        public Town HomeTown { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}