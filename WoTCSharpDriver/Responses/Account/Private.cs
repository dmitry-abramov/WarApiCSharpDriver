using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
namespace WarApi.Responses.Account
{
    [DataContract]
    public class Private
    {
        [Obsolete("Field will be off")]
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [Obsolete("Field will be off")]
        [JsonProperty("account_type_i18n")]
        public string AccountTypeI18n { get; set; }

        [JsonProperty("ban_info")]
        public string BanInfo { get; set; }

        [JsonProperty("ban_time")]
        public string BanTime { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("free_xp")]
        public string FreeXp { get; set; }

        [JsonProperty("friends")]
        public string Friends { get; set; }

        [JsonProperty("gold")]
        public string Gold { get; set; }

        [JsonProperty("is_bound_to_phone")]
        public string IsBoundToPhone { get; set; }

        [JsonProperty("is_premium")]
        public string IsPremium { get; set; }

        [JsonProperty("premium_expires_at")]
        public string PremiumExpiresAt { get; set; }

        [JsonProperty("restrictions")]
        Restriction Restrictions { get; set; }
    }

    [DataContract]
    public class Restriction
    {
        [JsonProperty("chat_ban_time")]
        public string ChatBanTime { get; set; }

        [JsonProperty("clan_time")]
        public string ClanTime { get; set; }
    }
}
