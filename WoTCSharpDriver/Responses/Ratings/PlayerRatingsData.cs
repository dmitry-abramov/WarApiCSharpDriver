using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WarApi.Responses.Ratings
{
    [DataContract]
    public class PlayerRatingsData
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("battles_to_play")]
        public int BattlesToPlay { get; set; }

        [JsonProperty("battles_count")]
        public StatisticsBySingleParameter BattlesCount { get; set; }

        [JsonProperty("capture_points ")]
        public StatisticsBySingleParameter CapturePoints { get; set; }

        [JsonProperty("damage_avg")]
        public StatisticsBySingleParameter DamageAvg { get; set; }

        [JsonProperty("damage_dealt")]
        public StatisticsBySingleParameter DamageDealt { get; set; }

        [JsonProperty("frags_avg")]
        public StatisticsBySingleParameter FragsAvg { get; set; }

        [JsonProperty("global_rating")]
        public StatisticsBySingleParameter GlobalRating { get; set; }

        [JsonProperty("hits_ratio")]
        public StatisticsBySingleParameter HitsRatio { get; set; }

        [JsonProperty("spotted_avg")]
        public StatisticsBySingleParameter SpottedAvg { get; set; }

        [JsonProperty("spotted_count")]
        public StatisticsBySingleParameter SpottedCount { get; set; }

        [JsonProperty("survived_ratio")]
        public StatisticsBySingleParameter SurvivedRatio { get; set; }

        [JsonProperty("wins_ratio")]
        public StatisticsBySingleParameter WinsRatio { get; set; }

        [JsonProperty("xp_amount")]
        public StatisticsBySingleParameter XpAmount { get; set; }

        [JsonProperty("xp_avg")]
        public StatisticsBySingleParameter XpAvg { get; set; }

        [JsonProperty("xp_max ")]
        public StatisticsBySingleParameter XpMax { get; set; }
    }
}
