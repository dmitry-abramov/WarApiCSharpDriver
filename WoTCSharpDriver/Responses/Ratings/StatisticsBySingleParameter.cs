using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class StatisticsBySingleParameter
    {
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "rank_delta")]
        public int RankDelta { get; set; }

        [DataMember(Name = "value")]
        public double Value { get; set; }
    }
}
