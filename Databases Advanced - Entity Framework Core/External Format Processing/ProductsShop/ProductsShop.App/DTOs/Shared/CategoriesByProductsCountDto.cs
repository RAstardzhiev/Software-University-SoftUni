namespace ProductsShop.App.DTOs.Shared
{
    using Newtonsoft.Json;

    public class CategoriesByProductsCountDto
    {
        [JsonProperty("category")]
        public string Name { get; set; }

        [JsonProperty("productsCount")]
        public int ProductsCount { get; set; }

        [JsonProperty("averagePrice")]
        public decimal AveragePrice { get; set; }

        [JsonProperty("totalRevenue")]
        public decimal TotalPriceSum { get; set; }
    }
}
