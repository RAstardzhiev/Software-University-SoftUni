namespace ProductsShop.Models
{
    public class CategoriesProducts
    {
        private CategoriesProducts()
        {
        }

        public CategoriesProducts(Category category, Product product)
        {
            this.Category = category;
            this.Product = product;
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public override string ToString()
            => $"{this.Category.Name}{this.Product.Name}";
    }
}
