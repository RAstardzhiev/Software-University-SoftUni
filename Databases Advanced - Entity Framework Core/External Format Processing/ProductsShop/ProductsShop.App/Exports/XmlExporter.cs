namespace ProductsShop.App.Exports
{
    using ProductsShop.App.DTOs.Shared;
    using ProductsShop.App.DTOs.XmlExport;
    using System;
    using System.Xml.Linq;

    public class XmlExporter
    {
        public void ExportProductsInRange(ProductsInRangeWithBuyerDto[] products, string filePath)
        {
            var xDoc = new XDocument();

            /* Setting the Root */
            xDoc.Add(new XElement("products")); // Root

            foreach (var product in products)
            {
                var element = new XElement("product",
                    new XAttribute("name", product.Name),
                    new XAttribute("price", product.Price),
                    new XAttribute("buyer", product.BuyerFullName));

                xDoc.Root.Add(element);
            }

            /* Save the result into a file */
            xDoc.Save(filePath);
        }

        public void ExportSellersWithSoldSoldProducts(SellerSoldProductsDto[] sellers, string filePath)
        {
            var xDoc = new XDocument();

            /* Setting the Root */
            xDoc.Add(new XElement("users")); // Root

            foreach (var user in sellers)
            {
                /* Setting User */
                var element = new XElement("user");

                if (user.UserFirstName != null)
                {
                    element.Add(new XAttribute("first-name", user.UserFirstName));
                }

                element.Add(new XAttribute("last-name", user.UserLastName));

                /* Setting Products */
                var productsElement = new XElement("sold-products");
                foreach (var product in user.SoldProducts)
                {
                    productsElement.Add(new XElement("product",
                        new XElement("name", product.Name),
                        new XElement("price", product.Price)));
                }

                /* Combine all Elements */
                element.Add(productsElement);
                xDoc.Root.Add(element);
            }

            xDoc.Save(filePath);
        }

        public void ExportCategoriesByProductsCount(CategoriesByProductsCountDto[] categories, string filePath)
        {
            var xDoc = new XDocument();

            /* Setting the Root */
            xDoc.Add(new XElement("categories")); // Root

            foreach (var category in categories)
            {
                xDoc.Root.Add(new XElement("category", new XAttribute("name", category.Name), 
                    new XElement("products-count", category.ProductsCount), 
                    new XElement("average-price", category.AveragePrice), 
                    new XElement("total-revenue", category.TotalPriceSum)));
            }

            xDoc.Save(filePath);
        }

        public void XmlExportUsersAndProducts(UsersAndProductsDto[] sellers, string filePath)
        {
            var xDoc = new XDocument();

            /* Setting the Root */
            xDoc.Add(new XElement("users", new XAttribute("count", sellers.Length))); // Root

            foreach (var user in sellers)
            {
                var userElement = new XElement("user");

                if (user.UserFirstName != null)
                {
                    userElement.Add(new XAttribute("first-name", user.UserFirstName));
                }

                userElement.Add(new XAttribute("last-name", user.UserLastName));

                if (user.Age != null)
                {
                    userElement.Add(new XAttribute("age", user.Age));
                }

                var soldProductsElement = new XElement("sold-products", 
                    new XAttribute("count", user.SoldProducts.Count));

                foreach (var product in user.SoldProducts)
                {
                    soldProductsElement.Add(new XElement("product", 
                        new XAttribute("name", product.Name), 
                        new XAttribute("price", product.Price)));
                }

                userElement.Add(soldProductsElement);
                xDoc.Root.Add(userElement);
            }

            xDoc.Save(filePath);
        }
    }
}
