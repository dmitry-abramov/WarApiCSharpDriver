using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class MapsResponseData
    {
        [DataMember(Name = "map_id")]
        public int MapId { get; set; }

        [DataMember(Name = "map_url")]
        public string MapUrl { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        // todo use consts
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }

    [DataContract]
    public class MapsResponse : ResponseBase<IList<MapsResponseData>>
    {
    }
}
