using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
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

    [DataContract]
    public class MapsResponse : ResponseBase<IList<MapsResponseData>>
    {
    }
}
