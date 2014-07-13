using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class FamePointsResponseData
    {
        [DataMember(Name = "account_id")]
        public int AccountId { get; set; }

        [DataMember(Name = "fame_points")]
        public int NamePoints { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }
    }

    [DataContract]
    public class FamePointsResponse : ResponseBase<IList<FamePointsResponseData>>
    {
    }
}
