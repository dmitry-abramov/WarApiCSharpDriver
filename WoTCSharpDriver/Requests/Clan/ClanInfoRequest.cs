using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClanInfoRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "info";
            }


        }

        [RequestParameter("clan_id", true)]
        public string ClanId { get; set; }
    }
}
