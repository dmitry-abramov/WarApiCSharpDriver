using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WarApi.Responses.Auth
{
    public class LoginResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
