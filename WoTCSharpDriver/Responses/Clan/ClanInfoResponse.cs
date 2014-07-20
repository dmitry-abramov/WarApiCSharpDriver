using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanInfoData
    {
        [DataMember(Name = "abbreviation")]
        public string Abbreviation { get; set; }

        [DataMember(Name = "clan_id")]
        public int ClanId { get; set; }

        // todo: use class Color
        [DataMember(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Clan color. Field will be disabled. Use field <href>Color</href>
        /// </summary>
        [DataMember(Name = "clan_color")]
        public string ClanColor { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "description_html")]
        public string DescriptionHtml { get; set; }

        [DataMember(Name = "is_clan_disbanded ")]
        public bool IsClanDisbanded { get; set; }

        [DataMember(Name = "members_count")]
        public int MembersCount { get; set; }

        [DataMember(Name = "motto")]
        public string Motto { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "owner_id")]
        public int OwnerId { get; set; }

        [DataMember(Name = "request_availability ")]
        public bool RequestAvailability { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }
        
        [DataMember(Name = "emblems")]
        public ClanEmblems Emblems { get; set; }

        [DataMember(Name = "members")]
        public IList<ClanMemberInfo> Members { get; set; }

        [DataMember(Name = "private")]
        public ClanPrivateInfo PrivateInfo { get; set; }
    }

    [DataContract]
    public class ClanInfoResponse : ResponseBase<Dictionary<int, ClanInfoData>>
    {
    }
}
