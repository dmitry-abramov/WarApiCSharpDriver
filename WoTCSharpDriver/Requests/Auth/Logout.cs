using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.Auth
{
    public class Logout : AuthRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "logout";
            }
        }
    }
}
