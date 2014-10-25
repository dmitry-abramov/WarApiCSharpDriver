using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.GlobalWar
{
    public class TopClansResponseData
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("clan_id")]
        public int ClanId { get; set; }

        // todo: use class Color
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("combats_count")]
        public int CombatsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        [JsonProperty("motto")]
        public string Motto { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("provinces_count")]
        public int ProvincesCount { get; set; }

        [JsonProperty("wins_count")]
        public int WinsCount { get; set; }

        [JsonProperty("emblems")]
        public ClanEmblems Emblems { get; set; }
    }

    public class TopClansResponse : ResponseBase<IList<TopClansResponseData>>
    {
    }
}
