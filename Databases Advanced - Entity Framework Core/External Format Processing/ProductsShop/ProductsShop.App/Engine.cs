namespace ProductsShop.App
{
    using Microsoft.EntityFrameworkCore;
    using ProductsShop.App.DTOs;
    using ProductsShop.App.Exports;
    using ProductsShop.App.Imports;
    using ProductsShop.Data;
    using ProductsShop.Models;
    using System;
    using System.Linq;

    public class Engine
    {
        private const string ProductsInRangeExportFilePath = "Exports/Json/ProductsInRange ({0}-{1}) {2}.json";
        private const string SuccessfullySoldProductsExportFilePath = "Exports/Json/SuccessfullySoldProducts.json";
        private const string CategoriesByProductsCountExportFilePath = "Exports/Json/CategoriesByProductsCount.json";
        private const string UsersAndProductsExportFilePath = "Exports/Json/UsersAndProducts.json";

        private JsonExporter jsonExporter;

        public Engine()
        {
            this.jsonExporter = new JsonExporter();
        }

        public Engine(JsonExporter jsonExporter)
        {
            this.jsonExporter = jsonExporter;
        }

        public void Run()
        {
            /* JSON Import */
            // ResetDatabase(new JSONImporter(new ProductsShopContext()));

            /* Export Without DTO */
            // this.JsonExportProductsInRangeWithoutDto(500, 1000); // Query 1 - Products In Range

            /* Export With DTO */
            // this.JsonExportProductsInRange(500, 1000); // Query 1 - Products In Range
            // this.JsonExportSuccessfullySoldProducts(); // Query 2 - Successfully Sold Products
            // this.JsonExportCategoriesByProductsCount(); // Query 3 - Categories By Products Count
            // this.JsonExportUsersAndProducts(); // Query 4 - Users and Products
            
            /* Xml Import */
            ResetDatabase(new XmlImporter(new ProductsShopContext()));
        }

        private static void ResetDatabase(Importer importer)
        {
            using (var context = new ProductsShopContext())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();
            }

            importer.Import();
        }

        private void JsonExportProductsInRangeWithoutDto(int minPrice, int maxPrice)
        {
            using (var context = new ProductsShopContext())
            {
                var products = context.Products
                    .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        seller = (p.Seller.FirstName == null)
                            ? p.Seller.LastName
                            : $"{p.Seller.FirstName} {p.Seller.LastName}"
                    })
                    .OrderBy(p => p.price)
                    .ToArray();

                var date = DateTime.Now.ToString("dd-MM-yyyy");
                var filePath = string.Format($"{ProductsInRangeExportFilePath} - Without DTO", minPrice, maxPrice, date);
                this.jsonExporter.Export(filePath, products);
            }
        }

        private void JsonExportProductsInRange(decimal minPrice, decimal maxPrice)
        {
            ProductsInRangeDto[] products = null;
            using (var context = new ProductsShopContext())
            {
                products = context.Products
                    .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
                    .Select(p => new ProductsInRangeDto()
                    {
                        Name = p.Name, 
                        Price = p.Price, 
                        SellerFullName = (p.Seller.FirstName == null)
                            ? p.Seller.LastName
                            : $"{p.Seller.FirstName} {p.Seller.LastName}"
                    })
                    .OrderBy(p => p.Price)
                    .ToArray();
            }

            var date = DateTime.Now.ToString("dd-MM-yyyy");
            var filePath = string.Format(ProductsInRangeExportFilePath, minPrice, maxPrice, date);
            this.jsonExporter.Export(filePath, products);
        }

        private void JsonExportSuccessfullySoldProducts()
        {
            SuccessfullySoldProductsSellerDto[] sellers = null;
            using (var context = new ProductsShopContext())
            {
                sellers = context.Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .Select(u => new SuccessfullySoldProductsSellerDto()
                    {
                        SellerFirstName = u.FirstName,
                        SellerLastName = u.LastName,
                        SoldProducts = u.SoldProducts
                            .Select(sp => new SuccessfullySoldProductsProductDto()
                            {
                                BuyerFirstName = sp.Buyer.FirstName,
                                BuyerLastName = sp.Buyer.LastName,
                                Price = sp.Price,
                                ProductName = sp.Name
                            })
                    })
                    .ToArray();
            }

            this.jsonExporter.Export(SuccessfullySoldProductsExportFilePath, sellers);
        }

        private void JsonExportCategoriesByProductsCount()
        {
            CategoriesByProductsCountDto[] categories = null;
            using (var context = new ProductsShopContext())
            {
                categories = context.Categories
                    .OrderBy(c => c.Name)
                    .Select(c => new CategoriesByProductsCountDto()
                    {
                        Name = c.Name,
                        ProductsCount = c.ProductsCategories.Count,
                        AveragePrice = c.ProductsCategories
                            .Select(pc => pc.Product.Price)
                            .Average(),
                        TotalPriceSum = c.ProductsCategories
                            .Select(pc => pc.Product.Price)
                            .Sum()
                    })
                    .ToArray();
            }

            this.jsonExporter.Export(CategoriesByProductsCountExportFilePath, categories);
        }

        private void JsonExportUsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context.Users
                    .Where(u => u.SoldProducts.Any())
                    .Select(u => new 
                    {
                        FirstName = u.FirstName, 
                        LastName = u.LastName, 
                        Age = u.Age ?? 0, 
                        SoldProducts = new
                        {
                            count = u.SoldProducts.Count,
                            products = u.SoldProducts.Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })
                        }
                    })
                    .OrderByDescending(u => u.SoldProducts.count)
                    .ThenBy(u => u.LastName)
                    .ToArray();

                var jsonReady = new
                {
                    usersCount = users.Length,
                    users = users
                };

                this.jsonExporter.Export(UsersAndProductsExportFilePath, jsonReady);
            }
        }
    }
}
