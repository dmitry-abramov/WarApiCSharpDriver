using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.GlobalWar
{
    [DataContract]
    public class ClansResponsData
    {
        [JsonProperty("clan_id")]
        public int ClanId { get; set; }

        [JsonProperty("provinces")]
        public IList<Province> Provinces { get; set; }
    }

    [DataContract]
    public class ClansResponse : ResponseBase<IList<ClansResponsData>>
    {
    }
}
