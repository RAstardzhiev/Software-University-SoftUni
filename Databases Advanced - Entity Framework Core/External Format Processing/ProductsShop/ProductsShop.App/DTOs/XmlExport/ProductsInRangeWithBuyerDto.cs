namespace ProductsShop.App.DTOs.XmlExport
{
    using Newtonsoft.Json;

    public class ProductsInRangeWithBuyerDto
    {
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public string BuyerFullName { get; set; }
    }
}
