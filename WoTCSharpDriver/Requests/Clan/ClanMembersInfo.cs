using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClanMembersInfo : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "membersinfo";
            }
        }

        [RequestParameter("member_id", true)]
        public string MemberId { get; set; }
    }
}
