using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanListData
    {
        [DataMember(Name = "abbreviation")]
        public string Abbreviation { get; set; }

        [DataMember(Name = "clan_id")]
        public int ClanId { get; set; }

        // todo: use class Color
        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "members_count")]
        public int MembersCount { get; set; }

        [DataMember(Name = "motto")]
        public string Motto { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "owner_id")]
        public int OwnerId { get; set; }

        [DataMember(Name = "owner_name")]
        public string OwnerName { get; set; }

        [DataMember(Name = "emblems")]
        public ClanEmblems Emblems { get; set; }
    }

    [DataContract]
    public class ClanListResponse : ResponseBase<IList<ClanListData>>
    {
    }
}
