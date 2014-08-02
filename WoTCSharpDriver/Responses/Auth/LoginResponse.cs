using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Auth
{
    [DataContract]
    public class LoginResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
