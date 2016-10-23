using Newtonsoft.Json;

namespace WarApi.Responses.Ratings
{
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
