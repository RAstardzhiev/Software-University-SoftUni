namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class Product
    {
        private Product()
        {
            this.CategoriesProducts = new HashSet<CategoriesProducts>();
        }

        public Product(string name, decimal price, User seller)
            : this()
        {
            this.Name = name;
            this.Price = price;
            this.Seller = seller;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }
        public User Buyer { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<CategoriesProducts> CategoriesProducts { get; set; }
    }
}
