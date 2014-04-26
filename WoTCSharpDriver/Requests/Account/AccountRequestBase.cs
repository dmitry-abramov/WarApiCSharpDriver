using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;
using WoTCSharpDriver.Requests;

namespace WoTCSharpDriver.Requests.Account
{
    public class AccountRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "account";
            }
        }

        [RequestParameter("language", false)]
        public string Language { get; set; }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
