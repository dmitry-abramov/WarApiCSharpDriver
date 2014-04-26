using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayersListData
    {
        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "nickname")]
        public string Nickname { get; set; }
    }

    public class PlayersListResponse : ResponseBase<IList<PlayersListData>>
    { 
    }
}
