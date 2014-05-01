using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Ratings
{
    public class PlayerRatingsRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "accounts";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }

        // todo: create constants for it
        [RequestParameter("type", true)]
        public string Type { get; set; }

        // todo: use DateTime
        [RequestParameter("date", true)]
        public string Date { get; set; }
    }
}
