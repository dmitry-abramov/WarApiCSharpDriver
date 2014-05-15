using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Clan
{
    [DataContract]
    public class ClanEmblems
    {
        [DataMember(Name = "bw_tank")]
        public Uri EmblemOnTank { get; set; }

        [DataMember(Name = "large")]
        public Uri LargeEmblem { get; set; }

        [DataMember(Name = "medium")]
        public Uri MediumEmblem { get; set; }

        [DataMember(Name = "small")]
        public Uri SmallEmblem { get; set; }
    }
}
