using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClanBattlesRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "battles";
            }
        }

        [RequestParameter("clan_id", true)]
        public string ClanId { get; set; }

        [RequestParameter("map_id", false)]
        public int MapId { get; set; }
    }
}
