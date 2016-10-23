using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WarApi.ConstantValues;

namespace WarApi.Responses.Account
{
    public class PlayerInfoData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("ban_info")]
        public string BanInfo { get; set; }

        [JsonProperty("ban_time")]
        public DateTime? BanTime { get; set; }

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

        [JsonProperty("private")]
        public Private Private { get; set; }

        [JsonProperty("statistics")]
        public PlayerStatistics Statistics { get; set; }
    }
    
    public class PlayerInfoResponse : ResponseBase<IDictionary<string, PlayerInfoData>>
    {
    }    
}
