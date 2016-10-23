using Newtonsoft.Json;

namespace WarApi.Responses.Auth
{
    public class LoginResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
