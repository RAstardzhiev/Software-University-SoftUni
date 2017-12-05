namespace ProductsShop.App.Imports
{
    using ProductsShop.Data;
    using ProductsShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class XmlImporter : Importer
    {
        /* 
         * From File -> XDocument.Load(string path) 
         * From string -> XDocument.Parse(string xml) 
        */

        private const string UsersXmlFilePath = "Imports/Xml/users.xml";
        private const string ProductsXmlFilePath = "Imports/Xml/products.xml";
        private const string CategoriesXmlFilePath = "Imports/Xml/categories.xml";

        public XmlImporter(ProductsShopContext context) 
            : base(context)
        {
        }

        public override void Import()
        {
            var users = this.DeserializeUsers();
            var products = this.DeserializeProducts();
            var categories = this.DeserializeCategories();

            base.SeedDatabase(users, products, categories);
        }

        private Category[] DeserializeCategories()
        {
            var xDoc = XDocument.Load(CategoriesXmlFilePath);
            var result = new Stack<Category>();

            foreach (var element in xDoc.Root.Elements())
            {
                // Extracting Category data
                var name = element?.Element("name")?.Value;
                if (name == null)
                {
                    continue;
                }

                // Adding the newly created Category to the Result
                var category = new Category(name);
                result.Push(category);
            }

            return result.ToArray();
        }

        /* Properties are Nested Elements */
        private Product[] DeserializeProducts()
        {
            var xDoc = XDocument.Load(ProductsXmlFilePath);
            var result = new Stack<Product>();

            foreach (var element in xDoc.Root.Elements())
            {
                // Extracting Product data
                var name = element?.Element("name")?.Value;
                decimal price;
                var isPriceValid = decimal.TryParse(element?.Element("price")?.Value, out price);

                if (name == null || !isPriceValid)
                {
                    continue;
                }

                // Adding the new product to the result
                var product = new Product(name, price, null);
                result.Push(product);
            }

            return result.ToArray();
        }

        /* Properties are Attributes of the Elements */
        protected User[] DeserializeUsers()
        {
            var xmlDoc = XDocument.Load(UsersXmlFilePath);
            var result = new Stack<User>();

            foreach (var element in xmlDoc.Root.Elements())
            {
                // Extracting user data
                var firstName = element?.Attribute("firstName")?.Value;
                var lastName = element?.Attribute("lastName")?.Value;
                var ageString = element?.Attribute("age")?.Value;
                if (lastName == null)
                {
                    continue;
                }

                // Creating User
                var user = new User(lastName);
                user.FirstName = firstName;

                int age;
                var isAgeValid = int.TryParse(ageString, out age);
                if (isAgeValid)
                {
                    user.Age = age;
                }

                // Assign the new user to the result
                result.Push(user);
            }

            return result.ToArray();
        }
    }
}
