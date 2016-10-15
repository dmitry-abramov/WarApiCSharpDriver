using Newtonsoft.Json;

namespace WarApi.CodeGenerator.Models.Api
{
    public class RequestParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool IsRequired { get; set; }
    }
}