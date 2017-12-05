namespace ProductsShop.App.Imports
{
    using ProductsShop.App.Interfaces;
    using ProductsShop.Data;
    using ProductsShop.Models;
    using System;
    using System.Collections.Generic;

    public abstract class Importer : IImporter
    {
        private ProductsShopContext context;
        private Random random;

        protected Importer(ProductsShopContext context)
        {
            this.random = new Random();
            this.context = context;
        }

        protected ProductsShopContext Context => this.context;

        public abstract void Import();

        protected void SeedDatabase(User[] users, Product[] products, Category[] categories)
        {
            this.AssignUsersToProductsw(users, products);
            var categoriesProducts = this.AddProductsToCategories(products, categories);

            using (this.Context)
            {
                this.Context.Users.AddRange(users);
                this.Context.Products.AddRange(products);
                this.Context.Categories.AddRange(categories);
                this.Context.CategoriesProducts.AddRange(categoriesProducts);

                this.Context.SaveChanges();
            }
        }

        protected HashSet<CategoriesProducts> AddProductsToCategories(Product[] products, Category[] categories)
        {
            var categoriesProducts = new HashSet<CategoriesProducts>(new CategoryProductsComparer());

            for (int i = 0; i < products.Length; i++)
            {
                var category = categories[this.random.Next(0, categories.Length)];
                var product = products[i];

                var mapping = new CategoriesProducts(category, product);

                categoriesProducts.Add(mapping);

                var isThereFurtherCategories = this.random.Next() % 2 == 0;
                if (isThereFurtherCategories)
                {
                    i--;
                }
            }

            return categoriesProducts;
        }

        protected void AssignUsersToProductsw(User[] users, Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                // Assign Seller
                var seller = users[this.random.Next(0, users.Length)];
                products[i].Seller = seller;

                // Assign Buyer
                var isBuyerAvailable = this.random.Next() % 2 == 0;
                if (isBuyerAvailable)
                {
                    var buyer = seller;
                    while (buyer == seller)
                    {
                        buyer = users[this.random.Next(0, users.Length)];
                    }

                    products[i].Buyer = buyer;
                }
            }
        }
    }
}
