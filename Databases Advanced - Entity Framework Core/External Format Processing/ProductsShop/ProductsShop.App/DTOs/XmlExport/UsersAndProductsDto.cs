namespace ProductsShop.App.DTOs.XmlExport
{
    using ProductsShop.Models;
    using System.Collections.Generic;

    public class UsersAndProductsDto
    {
        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public ICollection<Product> SoldProducts { get; set; }

        public int? Age { get; set; }
    }
}
