using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using WarApi.Utilities.Serialization;

namespace WarApi.Responses.Auth
{
    [DataContract]
    public class ProlongateResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
                
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime ExpiresAt { get; set; }
    }
}
