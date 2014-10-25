using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace WarApi.Responses.Auth
{
    public class ProlongateResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
                
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }
    }
}
