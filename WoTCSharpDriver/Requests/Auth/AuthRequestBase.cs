using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.Auth
{
    public class AuthRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "auth";
            }
        }
    }
}
