using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Tanks
{
    [DataContract]
    public class TanksStatisticsData
    {
        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }

        // todo: use enum
        [DataMember(Name = "mark_of_mastery")]
        public int MarkOfMastery { get; set; }

        [DataMember(Name = "max_frags")]
        public int MaxFrags { get; set; }

        [DataMember(Name = "max_xp")]
        public int MaxExpirience { get; set; }

        [DataMember(Name = "tank_id")]
        public string TankId { get; set; }

        [DataMember(Name = "in_garage")]
        public bool InGarage { get; set; }

        [DataMember(Name = "all")]
        public TankStatisticDetails All { get; set; }

        [DataMember(Name = "clan")]
        public TankStatisticDetails Clan { get; set; }

        [DataMember(Name = "company")]
        public TankStatisticDetails Company { get; set; }
    }

    [DataContract]
    public class TankStatisticDetails
    {
        [DataMember(Name = "battle_avg_xp")]
        public int BattleAverengeExpirience { get; set; }

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
        public int Expirience { get; set; }
    }

    [DataContract]
    public class TanksStatisticsResponse : ResponseBase<IDictionary<string, TanksStatisticsData>>
    {
    }
}
