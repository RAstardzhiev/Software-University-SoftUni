namespace ProductsShop.App.DTOs.JsonExport
{
    using Newtonsoft.Json;

    public class ProductsInRangeSellerDto
    {
        // [JsonIgnore] // Will exclude the property from Json conversion
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("seller")]
        public string SellerFullName { get; set; }
    }
}
