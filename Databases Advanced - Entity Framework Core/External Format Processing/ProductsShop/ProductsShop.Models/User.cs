namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        private User()
        {
            this.BoughtProducts = new HashSet<Product>();
            this.SoldProducts = new HashSet<Product>();
        }

        public User(string lastName)
            : this()
        {
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public ICollection<Product> BoughtProducts { get; set; }

        public ICollection<Product> SoldProducts { get; set; }
    }
}
