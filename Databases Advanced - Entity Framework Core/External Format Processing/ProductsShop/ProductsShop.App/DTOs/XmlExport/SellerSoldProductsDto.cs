namespace ProductsShop.App.DTOs.XmlExport
{
    using ProductsShop.Models;
    using System.Collections.Generic;

    public class SellerSoldProductsDto
    {
        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public ICollection<Product> SoldProducts { get; set; }
    }
}
