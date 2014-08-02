using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class StatisticsBySingleParameter
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rank_delta")]
        public int RankDelta { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
