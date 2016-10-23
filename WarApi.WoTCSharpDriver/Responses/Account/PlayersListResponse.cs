using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarApi.Responses.Account
{
    public class PlayersListData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }
    }

    public class PlayersListResponse : ResponseBase<IList<PlayersListData>>
    { 
    }
}
