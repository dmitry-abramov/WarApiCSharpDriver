using System.Runtime.Serialization;
namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayerStatistics
    {
        [DataMember(Name = "max_damage")]
        public int MaxDamage { get; set; }

        [DataMember(Name = "max_damage_vehicle")]
        public int MaxDamageVehicle { get; set; }

        [DataMember(Name = "max_xp")]
        public int MaxXp { get; set; }

        [DataMember(Name = "all")]
        public PlayerStatisticsDetails All { get; set; }

        [DataMember(Name = "clan")]
        public PlayerStatisticsDetails Clan { get; set; }

        [DataMember(Name = "complany")]
        public PlayerStatisticsDetails Company { get; set; }

        [DataMember(Name = "historical")]
        public PlayerStatisticsDetails Historical { get; set; }
    }

    [DataContract]
    public class PlayerStatisticsDetails
    {
        [DataMember(Name = "battle_avg_xp")]
        public int BattleAvgXp { get; set; }

        [DataMember(Name = "battles")]
        public int Battles { get; set; }

        [DataMember(Name = "capture_points")]
        public int CapturePoints { get; set; }

        [DataMember(Name = "damage_dealt")]
        public int DamageDealt { get; set; }

        [DataMember(Name = "damage_received")]
        public int DamageReceived { get; set; }

        [DataMember(Name = "draws")]
        public int Draws { get; set; }

        [DataMember(Name = "dropped_capture_points")]
        public int DroppedCapturePoints { get; set; }

        [DataMember(Name = "frags")]
        public int Frags { get; set; }

        [DataMember(Name = "hits")]
        public int Hits { get; set; }

        [DataMember(Name = "hits_percents")]
        public int HitsPercents { get; set; }

        [DataMember(Name = "losses")]
        public int Losses { get; set; }

        [DataMember(Name = "shots")]
        public int Shots { get; set; }

        [DataMember(Name = "spotted")]
        public int Spotted { get; set; }

        [DataMember(Name = "survived_battles")]
        public int SurvivedBattles { get; set; }

        [DataMember(Name = "wins")]
        public int Wins { get; set; }

        [DataMember(Name = "xp")]
        public int Xp { get; set; }
    }
}
