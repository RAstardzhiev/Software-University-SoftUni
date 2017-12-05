namespace ProductsShop.App
{
    using Newtonsoft.Json;
    using ProductsShop.App.Imports;
    using ProductsShop.Data;
    using ProductsShop.Models;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class JSONImporter : Importer
    {
        private const string UsersJsonFilePath = "Imports/Json/users.json";
        private const string ProductsJsonFilePath = "Imports/Json/products.json";
        private const string CategoriesJsonFilePath = "Imports/Json/categories.json";

        public JSONImporter(ProductsShopContext context) 
            : base(context)
        {
        }

        // Install-Package Newtonsoft.Json

        public override void Import()
        {
            var users = Deserialize<User>(UsersJsonFilePath);
            var products = Deserialize<Product>(ProductsJsonFilePath);
            var categories = Deserialize<Category>(CategoriesJsonFilePath);

            base.SeedDatabase(users, products, categories);
        }

        protected TModel[] Deserialize<TModel>(string usersJsonFilePath)
        {
            var jsonString = File.ReadAllText(usersJsonFilePath);
            var collection = JsonConvert.DeserializeObject<IEnumerable<TModel>>(jsonString)
                .ToArray();

            return collection;
        }
    }
}
