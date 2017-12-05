namespace ProductsShop.App.DTOs.JsonExport
{
    using Newtonsoft.Json;

    public class SuccessfullySoldProductsProductDto
    {
        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("buyerFirstName")]
        public string BuyerFirstName { get; set; }

        [JsonProperty("buyerLastName")]
        public string BuyerLastName { get; set; }
    }
}
