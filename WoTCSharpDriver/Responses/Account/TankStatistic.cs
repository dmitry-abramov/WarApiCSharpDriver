using Newtonsoft.Json;

namespace WarApi.Responses.Account
{
    public class TankStatistic
    {
        [JsonProperty("battles")]
        public int Battles { get; set; }
        
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
