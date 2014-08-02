using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayerStatistics
    {
        [JsonProperty("max_damage")]
        public int MaxDamage { get; set; }

        [JsonProperty("max_damage_vehicle")]
        public int MaxDamageVehicle { get; set; }

        [JsonProperty("max_xp")]
        public int MaxXp { get; set; }

        [JsonProperty("all")]
        public PlayerStatisticsDetails All { get; set; }

        [JsonProperty("clan")]
        public PlayerStatisticsDetails Clan { get; set; }

        [JsonProperty("complany")]
        public PlayerStatisticsDetails Company { get; set; }

        [JsonProperty("historical")]
        public PlayerStatisticsDetails Historical { get; set; }
    }

    [DataContract]
    public class PlayerStatisticsDetails
    {
        [JsonProperty("battle_avg_xp")]
        public int BattleAvgXp { get; set; }

        [JsonProperty("battles")]
        public int Battles { get; set; }

        [JsonProperty("capture_points")]
        public int CapturePoints { get; set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; set; }

        [JsonProperty("damage_received")]
        public int DamageReceived { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("dropped_capture_points")]
        public int DroppedCapturePoints { get; set; }

        [JsonProperty("frags")]
        public int Frags { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("hits_percents")]
        public int HitsPercents { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("spotted")]
        public int Spotted { get; set; }

        [JsonProperty("survived_battles")]
        public int SurvivedBattles { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }
    }
}
