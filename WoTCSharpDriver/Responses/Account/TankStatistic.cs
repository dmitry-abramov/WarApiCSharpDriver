using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class TankStatistic
    {
        [DataMember(Name = "battles")]
        [JsonProperty(PropertyName = "battles")]
        public int Battles { get; set; }
        
        [DataMember(Name = "wins")]
        [JsonProperty(PropertyName = "wins")]
        public int Wins { get; set; }
    }
}
