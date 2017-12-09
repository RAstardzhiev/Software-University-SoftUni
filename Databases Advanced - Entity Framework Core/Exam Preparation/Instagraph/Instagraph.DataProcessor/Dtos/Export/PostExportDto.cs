using Newtonsoft.Json;

namespace Instagraph.DataProcessor.Dtos.Export
{
    class PostExportDto
    {
        public int Id { get; set; }

        [JsonProperty("Picture")]
        public string PicturePath { get; set; }

        [JsonProperty("User")]
        public string Username { get; set; }
    }
}
