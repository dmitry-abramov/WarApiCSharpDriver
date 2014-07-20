using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class RatingTypesData
    {
        [DataMember(Name = "rank_fields")]
        IList<string> RankFields { get; set; }

        [DataMember(Name = "threshold")]
        int Threshold { get; set; }

        // todo create consts
        [DataMember(Name = "type")]
        string Type { get; set; }
    }

    [DataContract]
    public class RatingTypesResponse : ResponseBase<IList<RatingTypesData>>
    {
    }
}
