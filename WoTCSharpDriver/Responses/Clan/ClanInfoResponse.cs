using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WarApi.Responses.Clan
{
    public class ClanInfoData
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("clan_id")]
        public int ClanId { get; set; }

        // todo: use class Color
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// Clan color. Field will be disabled. Use field <href>Color</href>
        /// </summary>
        [JsonProperty("clan_color")]
        public string ClanColor { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("is_clan_disbanded ")]
        public bool IsClanDisbanded { get; set; }

        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        [JsonProperty("motto")]
        public string Motto { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("request_availability ")]
        public bool RequestAvailability { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        
        [JsonProperty("emblems")]
        public ClanEmblems Emblems { get; set; }

        [JsonProperty("members")]
        public IList<ClanMemberInfo> Members { get; set; }

        [JsonProperty("private")]
        public ClanPrivateInfo PrivateInfo { get; set; }
    }

    public class ClanInfoResponse : ResponseBase<Dictionary<int, ClanInfoData>>
    {
    }
}
