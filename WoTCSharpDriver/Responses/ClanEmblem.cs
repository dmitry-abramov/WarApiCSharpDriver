using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WarApi.Responses
{
    [DataContract]
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
