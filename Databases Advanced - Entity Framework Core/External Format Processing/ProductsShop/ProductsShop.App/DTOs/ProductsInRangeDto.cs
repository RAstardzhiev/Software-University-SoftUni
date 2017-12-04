namespace ProductsShop.App.DTOs
{
    using Newtonsoft.Json;

    public class ProductsInRangeDto
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
