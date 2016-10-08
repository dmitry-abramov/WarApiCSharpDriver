using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.GlobalWar
{
    public class ClansResponsData
    {
        [JsonProperty("clan_id")]
        public int ClanId { get; set; }

        [JsonProperty("provinces")]
        public IList<Province> Provinces { get; set; }
    }

    public class ClansResponse : ResponseBase<IList<ClansResponsData>>
    {
    }
}
