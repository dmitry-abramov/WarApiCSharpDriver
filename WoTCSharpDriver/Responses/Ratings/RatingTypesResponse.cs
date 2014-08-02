using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class RatingTypesData
    {
        [JsonProperty("rank_fields")]
        IList<string> RankFields { get; set; }

        [JsonProperty("threshold")]
        int Threshold { get; set; }

        // todo create consts
        [JsonProperty("type")]
        string Type { get; set; }
    }

    [DataContract]
    public class RatingTypesResponse : ResponseBase<IList<RatingTypesData>>
    {
    }
}
