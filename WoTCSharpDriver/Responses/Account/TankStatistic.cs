using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace WarApi.Responses.Account
{
    [DataContract]
    public class TankStatistic
    {
        [JsonProperty("battles")]
        public int Battles { get; set; }
        
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
