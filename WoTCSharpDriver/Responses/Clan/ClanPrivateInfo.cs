using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanPrivateInfo
    {
        [DataMember(Name = "chips_count")]
        public int ChipsCount { get; set; }

        [DataMember(Name = "treasury")]
        public int Treasury { get; set; }
    }
}
