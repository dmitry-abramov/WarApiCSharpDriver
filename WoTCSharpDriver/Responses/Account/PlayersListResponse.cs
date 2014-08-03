using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WarApi.Responses.Account
{
    [DataContract]
    public class PlayersListData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }
    }

    [DataContract]
    public class PlayersListResponse : ResponseBase<IList<PlayersListData>>
    { 
    }
}
