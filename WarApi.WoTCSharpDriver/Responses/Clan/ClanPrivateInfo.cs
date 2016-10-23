using Newtonsoft.Json;

namespace WarApi.Responses.Clan
{
    public class ClanPrivateInfo
    {
        [JsonProperty("chips_count")]
        public int ChipsCount { get; set; }

        [JsonProperty("treasury")]
        public int Treasury { get; set; }
    }
}
