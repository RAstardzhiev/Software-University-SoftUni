namespace P01_BillsPaymentSystem.Data.Models
{
    using System.Collections.Generic;

    public class User
    {
        private User()
        {
            this.PaymentMethods = new HashSet<PaymentMethod>();
        }

        public User(string firstName, string lastName, string email, string password) 
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
        }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
