using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayerInfoData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("clan_id")]
        public string ClanId { get; set; }

        //todo: use languages consts
        [JsonProperty("client_language")]
        public string ClientLanguage { get; set; }

        //todo: use DateTime
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("global_rating")]
        public int GlobalRating { get; set; }

        //todo: use timestamp
        [JsonProperty("last_battle_time")]
        public string LastBattleTime { get; set; }

        //todo: use timestamp
        [JsonProperty("logout_at")]
        public string LogoutAt { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        //todo: use timestamp
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }

        [JsonProperty("private")]
        public Private Private { get; set; }
    }
    
    [DataContract]
    public class PlayerInfoResponse : ResponseBase<PlayerInfoData>
    {
    }    
}
