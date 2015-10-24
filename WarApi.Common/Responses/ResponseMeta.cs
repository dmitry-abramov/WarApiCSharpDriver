using Newtonsoft.Json;

namespace WarApi.Responses
{    
    public class ResponseMetaData
    {        
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
