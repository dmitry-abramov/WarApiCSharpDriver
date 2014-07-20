using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Auth
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }
    }
}
