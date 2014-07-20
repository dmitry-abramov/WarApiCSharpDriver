using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanMemberInfo
    {
        [DataMember(Name = "account_id")]
        public int AccountId { get; set; }

        [DataMember(Name = "account_name")]
        public string AccountName { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }

        [DataMember(Name = "role_i18n")]
        public string LocalizedRole { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }
    }
}
