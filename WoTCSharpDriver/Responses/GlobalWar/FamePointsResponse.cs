using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.GlobalWar
{
    public class FamePointsResponseData
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("fame_points")]
        public int NamePoints { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class FamePointsResponse : ResponseBase<IList<FamePointsResponseData>>
    {
    }
}
