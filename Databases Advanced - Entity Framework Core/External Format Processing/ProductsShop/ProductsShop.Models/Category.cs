namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class Category 
    {
        private Category()
        {
            this.ProductsCategories = new HashSet<CategoriesProducts>();
        }

        public Category(string name)
            : this()
        {
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CategoriesProducts> ProductsCategories { get; set; }
    }
}
