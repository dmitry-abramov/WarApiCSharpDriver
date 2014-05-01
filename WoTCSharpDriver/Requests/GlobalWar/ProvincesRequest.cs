using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.GlobalWar
{
    public class ProvincesRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "provinces";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("province_id", false)]
        public string ProvinceId { get; set; }
    }
}
