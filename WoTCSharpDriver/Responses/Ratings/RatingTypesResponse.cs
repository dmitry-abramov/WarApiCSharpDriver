using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WarApi.ConstantValues;

namespace WarApi.Responses.Ratings
{
    [DataContract]
    public class RatingTypesData
    {
        [JsonProperty("rank_fields")]
        public IList<string> RankFields { get; set; }

        [JsonProperty("threshold")]
        public int Threshold { get; set; }

        [JsonProperty("type")]
        public RatingType Type { get; set; }
    }

    [DataContract]
    public class RatingTypesResponse : ResponseBase<IDictionary<RatingType, RatingTypesData>>
    {
    }
}
