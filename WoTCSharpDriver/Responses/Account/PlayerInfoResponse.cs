using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WarApi.ConstantVlaues;

namespace WarApi.Responses.Account
{
    [DataContract]
    public class PlayerInfoData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("clan_id")]
        public string ClanId { get; set; }

        [JsonProperty("client_language")]
        public Language ClientLanguage { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("global_rating")]
        public int GlobalRating { get; set; }

        [JsonProperty("last_battle_time")]
        public DateTime LastBattleTime { get; set; }

        [JsonProperty("logout_at")]
        public DateTime LogoutAt { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Obsolete("Use achievements api")]
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }

        [JsonProperty("private")]
        public Private Private { get; set; }

        [JsonProperty("statistics")]
        public PlayerStatistics Statistics { get; set; }
    }
    
    [DataContract]
    public class PlayerInfoResponse : ResponseBase<IDictionary<string, PlayerInfoData>>
    {
    }    
}
