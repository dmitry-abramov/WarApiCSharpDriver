using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Account
{
    public class PlayerInfoRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "info";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }
    }
}
