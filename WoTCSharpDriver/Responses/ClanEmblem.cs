using System;
using Newtonsoft.Json;

namespace WarApi.Responses
{
    public class ClanEmblems
    {
        [JsonProperty("bw_tank")]
        public Uri EmblemOnTank { get; set; }

        [JsonProperty("large")]
        public Uri LargeEmblem { get; set; }

        [JsonProperty("medium")]
        public Uri MediumEmblem { get; set; }

        [JsonProperty("small")]
        public Uri SmallEmblem { get; set; }
    }
}
