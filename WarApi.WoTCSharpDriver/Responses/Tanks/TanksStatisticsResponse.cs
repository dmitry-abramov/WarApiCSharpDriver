using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.Tanks
{
    public class TanksStatisticsData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        // todo: use enum
        [JsonProperty("mark_of_mastery")]
        public int MarkOfMastery { get; set; }

        [JsonProperty("max_frags")]
        public int MaxFrags { get; set; }

        [JsonProperty("max_xp")]
        public int MaxExpirience { get; set; }

        [JsonProperty("tank_id")]
        public string TankId { get; set; }

        //todo: this is stub
        [JsonProperty("frags")]
        public IDictionary<string, int> Frags { get; set; }

        //todo: this is stub
        [JsonProperty("in_garage")]
        public IDictionary<string, bool> InGarage { get; set; }

        [JsonProperty("all")]
        public TankStatisticDetailsExtended All { get; set; }

        [JsonProperty("clan")]
        public TankStatisticDetails Clan { get; set; }

        [JsonProperty("company")]
        public TankStatisticDetails Company { get; set; }

        [JsonProperty("stronghold_defense")]
        public TankStatisticDetailsExtended StrongholdDefence { get; set; }

        [JsonProperty("stronghold_skirmish")]
        public TankStatisticDetailsExtended StrongholdSkirmish { get; set; }

        [JsonProperty("team")]
        public TankStatisticDetails Team { get; set; }

        [JsonProperty("regular_team")]
        public TankStatisticDetails RegularTeam { get; set; }

        [JsonProperty("random")]
        public TankStatisticDetails Random { get; set; }

        [JsonProperty("globalmap")]
        public TankStatisticDetailsExtended GlobalMap { get; set; }
    }

    public class TankStatisticDetails
    {
        [JsonProperty("battle_avg_xp")]
        public int BattleAverengeExpirience { get; set; }

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
        public int Expirience { get; set; }

        [JsonProperty("max_xp")]
        public int MaxExpirience { get; set; }

        [JsonProperty("max_damage")]
        public int MaxDamage { get; set; }

        [JsonProperty("max_frags")]
        public int MaxFrags { get; set; }

        [JsonProperty("battles_on_stunning_vehicles")]
        public int BattlesOnStannigVehicles { get; set; }

        [JsonProperty("stun_assisted_damage")]
        public int StunAssistedDamage { get; set; }

        [JsonProperty("stun_number")]
        public int StunNumber { get; set; }
    }

    public class TankStatisticDetailsExtended : TankStatisticDetails
    {
        [JsonProperty("no_damage_direct_hits_received")]
        public int NoDamageDirectHitsReceived { get; set; }

        [JsonProperty("direct_hits_received")]
        public int DirectHitsReceived { get; set; }

        [JsonProperty("piercings")]
        public int Piercings { get; set; }

        [JsonProperty("piercings_received")]
        public int PiercingsReceived { get; set; }

        [JsonProperty("explosion_hits")]
        public int ExplosionHits { get; set; }

        [JsonProperty("explosion_hits_received")]
        public int ExplosionHitsReceived { get; set; }

        [JsonProperty("tanking_factor")]
        public double TankingFactor { get; set; }

        [JsonProperty("avg_damage_assisted")]
        public double AvgDamageAssisted { get; set; }

        [JsonProperty("avg_damage_assisted_track")]
        public double AvgDamageAssistedTrack { get; set; }

        [JsonProperty("avg_damage_assisted_radio")]
        public double AvgDamageAssistedRadio { get; set; }

        [JsonProperty("avg_damage_blocked")]
        public double AvgDamageAssistedBlocked { get; set; }        
    }

    public class TanksStatisticsResponse : ResponseBase<IDictionary<string, IList<TanksStatisticsData>>>
    {
    }
}
