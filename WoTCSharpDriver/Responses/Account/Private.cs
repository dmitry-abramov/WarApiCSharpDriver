using System;
using System.Runtime.Serialization;
namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class Private
    {
        [Obsolete("field will be off")]
        [DataMember(Name = "account_type")]
        public string AccountType { get; set; }

        [Obsolete("field will be off")]
        [DataMember(Name = "account_type_i18n")]
        public string AccountTypeI18n { get; set; }

        [DataMember(Name = "ban_info")]
        public string BanInfo { get; set; }

        [DataMember(Name = "ban_time")]
        public string BanTime { get; set; }

        [DataMember(Name = "credits")]
        public string Credits { get; set; }

        [DataMember(Name = "free_xp")]
        public string FreeXp { get; set; }

        [DataMember(Name = "friends")]
        public string Friends { get; set; }

        [DataMember(Name = "gold")]
        public string Gold { get; set; }

        [DataMember(Name = "is_bound_to_phone")]
        public string IsBoundToPhone { get; set; }

        [DataMember(Name = "is_premium")]
        public string IsPremium { get; set; }

        [DataMember(Name = "premium_expires_at")]
        public string PremiumExpiresAt { get; set; }

        [DataMember(Name = "restrictions")]
        Restriction Restrictions { get; set; }
    }

    [DataContract]
    public class Restriction
    {
        [DataMember(Name = "chat_ban_time")]
        public string ChatBanTime { get; set; }

        [DataMember(Name = "clan_time")]
        public string ClanTime { get; set; }
    }
}
