using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.GlobalWar
{
    public class TournamentsReqest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tournaments";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("province_id", true)]
        public string ProvinceId { get; set; }
    }
}
