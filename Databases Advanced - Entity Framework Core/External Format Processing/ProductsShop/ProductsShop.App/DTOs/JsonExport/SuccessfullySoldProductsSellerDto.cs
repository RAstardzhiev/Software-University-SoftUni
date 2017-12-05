namespace ProductsShop.App.DTOs.JsonExport
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SuccessfullySoldProductsSellerDto
    {
        [JsonProperty("firstName")]
        public string SellerFirstName { get; set; }

        [JsonProperty("lastName")]
        public string SellerLastName { get; set; }

        [JsonProperty("soldProducts")]
        public IEnumerable<SuccessfullySoldProductsProductDto> SoldProducts { get; set; }
    }
}
