using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayerInfoData
    {
        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }

        [DataMember(Name = "clan_id")]
        public string ClanId { get; set; }

        //todo: use languages consts
        [DataMember(Name = "client_language")]
        public string ClientLanguage { get; set; }

        //todo: use DateTime
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "global_rating")]
        public int GlobalRating { get; set; }

        //todo: use timestamp
        [DataMember(Name = "last_battle_time")]
        public string LastBattleTime { get; set; }

        //todo: use timestamp
        [DataMember(Name = "logout_at")]
        public string LogoutAt { get; set; }

        [DataMember(Name = "nickname")]
        public string Nickname { get; set; }

        //todo: use timestamp
        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "achievements")]
        public Achievements Achievements { get; set; }

        [DataMember(Name = "private")]
        public Private Private { get; set; }
    }
    
    [DataContract]
    public class PlayerInfoResponse : ResponseBase<PlayerInfoData>
    {
    }    
}
