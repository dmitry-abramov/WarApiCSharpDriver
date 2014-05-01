using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClansRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "clan";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
