using Newtonsoft.Json;

namespace WarApi.Responses.Clan
{
    public class ClanMemberInfo
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("role_i18n")]
        public string LocalizedRole { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
