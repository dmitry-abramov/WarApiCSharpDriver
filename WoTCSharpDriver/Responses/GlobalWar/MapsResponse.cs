using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.GlobalWar
{
    public class MapsResponseData
    {
        [JsonProperty("map_id")]
        public int MapId { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        // todo use consts
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MapsResponse : ResponseBase<IList<MapsResponseData>>
    {
    }
}
