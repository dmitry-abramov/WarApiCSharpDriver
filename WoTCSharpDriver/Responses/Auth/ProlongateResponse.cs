using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Auth
{
    [DataContract]
    public class ProlongateResponse
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }

        // todo: use date time
        [DataMember(Name = "expires_at")]
        public string ExpiresAt { get; set; }
    }
}
