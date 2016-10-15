using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Api
{
    public class ResponseParameter
    {
        [JsonProperty("name")]
        public IEnumerable<string> Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
