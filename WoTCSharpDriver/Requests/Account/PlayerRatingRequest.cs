using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Account
{
    public class PlayerRatingRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "ratings";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }
    }
}
