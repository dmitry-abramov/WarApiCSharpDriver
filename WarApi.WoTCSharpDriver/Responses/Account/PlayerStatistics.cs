using Newtonsoft.Json;

namespace WarApi.Responses.Account
{
    public class PlayerStatistics
    {
        [JsonProperty("frags")]
        public int? Frags { get; set; }

        [JsonProperty("max_xp")]
        public int MaxXp { get; set; }

        [JsonProperty("max_xp_tank_id")]
        public int MaxXpTankId { get; set; }

        [JsonProperty("max_damage")]
        public int MaxDamage { get; set; }

        [JsonProperty("max_damage_tank_id")]
        public int MaxDamageTankId { get; set; }

        [JsonProperty("max_frags")]
        public int MaxFrags { get; set; }

        [JsonProperty("max_frags_tank_id")]
        public int MaxFragsTankId { get; set; }

        [JsonProperty("trees_cut")]
        public int TreesCut { get; set; }

        //for some players this field is null
        [JsonProperty("max_damage_vehicle", NullValueHandling = NullValueHandling.Ignore)]        
        public int MaxDamageVehicle { get; set; }

        [JsonProperty("all")]
        public PlayerStatisticsDetails All { get; set; }

        [JsonProperty("clan")]
        public PlayerStatisticsDetails Clan { get; set; }

        [JsonProperty("company")]
        public PlayerStatisticsDetails Company { get; set; }

        [JsonProperty("historical")]
        public PlayerStatisticsDetails Historical { get; set; }

        [JsonProperty("globalmap_absolute")]
        public PlayerStatisticsDetails GlobalMapAbsolute { get; set; }

        [JsonProperty("globalmap_champion")]
        public PlayerStatisticsDetails GlobalMapChampion { get; set; }

        [JsonProperty("globalmap_middle")]
        public PlayerStatisticsDetails GlobalMapMiddle { get; set; }

        [JsonProperty("random")]
        public PlayerStatisticsDetails Random { get; set; }

        [JsonProperty("regular_team")]
        public PlayerStatisticsDetails RegularTeam { get; set; }

        [JsonProperty("stronghold_defense")]
        public PlayerStatisticsDetails StrongholdDefense { get; set; }

        [JsonProperty("stronghold_skirmish")]
        public PlayerStatisticsDetails StrongholdSkirmish { get; set; }

        [JsonProperty("team")]
        public PlayerStatisticsDetails Team { get; set; }
    }

    public class PlayerStatisticsDetails
    {
        [JsonProperty("avg_damage_assisted")]
        public double AvgDamageAssisted { get; set; }

        [JsonProperty("avg_damage_assisted_track")]
        public double AvgDamageAssistedTrack { get; set; }

        [JsonProperty("avg_damage_assisted_radio")]
        public double AvgDamageAssistedRadio { get; set; }

        [JsonProperty("avg_damage_blocked")]
        public double AvgDamageAssistedBlocked { get; set; }

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

        [JsonProperty("direct_hits_received")]
        public int DirectHitsReceived { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("dropped_capture_points")]
        public int DroppedCapturePoints { get; set; }

        [JsonProperty("explosion_hits")]
        public int ExplosionHits { get; set; }

        [JsonProperty("explosion_hits_received")]
        public int ExplosionHitsReceived { get; set; }
        
        [JsonProperty("frags")]
        public int Frags { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("hits_percents")]
        public int HitsPercents { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("max_xp")]
        public int MaxXp { get; set; }

        [JsonProperty("max_xp_tank_id")]
        public int? MaxXpTankId { get; set; }

        [JsonProperty("max_damage")]
        public int MaxDamage { get; set; }

        [JsonProperty("max_damage_tank_id")]
        public int? MaxDamageTankId { get; set; }

        [JsonProperty("max_frags")]
        public int MaxFrags { get; set; }

        [JsonProperty("max_frags_tank_id")]
        public int? MaxFragsTankId { get; set; }

        [JsonProperty("no_damage_direct_hits_received")]
        public int NoDamageDirectHitsReceived { get; set; }

        [JsonProperty("piercings")]
        public int Piercings { get; set; }

        [JsonProperty("piercings_received")]
        public int PiercingsReceived { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("spotted")]
        public int Spotted { get; set; }

        [JsonProperty("survived_battles")]
        public int SurvivedBattles { get; set; }

        [JsonProperty("tanking_factor")]
        public double TankingFactor { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("battles_on_stunning_vehicles")]
        public int BattlesOnStannigVehicles { get; set; }

        [JsonProperty("stun_assisted_damage")]
        public int StunAssistedDamage { get; set; }

        [JsonProperty("stun_number")]
        public int StunNumber { get; set; }
    }
}
