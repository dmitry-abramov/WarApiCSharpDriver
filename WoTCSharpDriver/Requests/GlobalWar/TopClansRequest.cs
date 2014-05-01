using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.GlobalWar
{
    public class TopClansRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "top";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        // note: wins_count, combats_count, provinces_count
        // todo: create consts
        [RequestParameter("order_by", false)]
        public string OrderBy { get; set; }
    }
}
