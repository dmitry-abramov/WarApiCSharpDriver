using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Auth
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }
    }
}
