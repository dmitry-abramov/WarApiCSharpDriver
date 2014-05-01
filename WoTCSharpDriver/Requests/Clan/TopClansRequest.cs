using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class TopClansRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "top";
            }
        }

        [RequestParameter("map_id", false)]
        public int MapId { get; set; }

        // note: current_season or current_step
        // todo: create consts
        [RequestParameter("time", false)]
        public string Time { get; set; }
    }
}
