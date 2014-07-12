using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class PlayerRatingsData
    {
        [DataMember(Name = "account_id")]
        public int AccountId { get; set; }

        [DataMember(Name = "battles_to_play")]
        public int BattlesToPlay { get; set; }

        [DataMember(Name = "battles_count")]
        public StatisticsBySingleParameter BattlesCount { get; set; }

        [DataMember(Name = "capture_points ")]
        public StatisticsBySingleParameter CapturePoints { get; set; }

        [DataMember(Name = "damage_avg")]
        public StatisticsBySingleParameter DamageAvg { get; set; }

        [DataMember(Name = "damage_dealt")]
        public StatisticsBySingleParameter DamageDealt { get; set; }

        [DataMember(Name = "frags_avg")]
        public StatisticsBySingleParameter FragsAvg { get; set; }

        [DataMember(Name = "global_rating")]
        public StatisticsBySingleParameter GlobalRating { get; set; }

        [DataMember(Name = "hits_ratio")]
        public StatisticsBySingleParameter HitsRatio { get; set; }

        [DataMember(Name = "spotted_avg")]
        public StatisticsBySingleParameter SpottedAvg { get; set; }

        [DataMember(Name = "spotted_count")]
        public StatisticsBySingleParameter SpottedCount { get; set; }

        [DataMember(Name = "survived_ratio")]
        public StatisticsBySingleParameter SurvivedRatio { get; set; }

        [DataMember(Name = "wins_ratio")]
        public StatisticsBySingleParameter WinsRatio { get; set; }

        [DataMember(Name = "xp_amount")]
        public StatisticsBySingleParameter XpAmount { get; set; }

        [DataMember(Name = "xp_avg")]
        public StatisticsBySingleParameter XpAvg { get; set; }

        [DataMember(Name = "xp_max ")]
        public StatisticsBySingleParameter XpMax { get; set; }
    }
}
