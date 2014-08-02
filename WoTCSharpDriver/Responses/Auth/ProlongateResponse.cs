using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Auth
{
    [DataContract]
    public class ProlongateResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        // todo: use date time
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
    }
}
