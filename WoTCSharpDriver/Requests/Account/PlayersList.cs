using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Account
{
    public class PlayersList : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "list";
            }
        }

        [RequestParameter("search", true)]
        public string Search { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }

        public PlayersList()
        {
            Limit = 100;
        }
    }
}
