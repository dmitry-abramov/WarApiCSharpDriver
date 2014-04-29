using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Auth
{
    public class LoginRequest : AuthRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "login";
            }
        }
                
        // note: use UTC format
        // todo: make DateTime
        [RequestParameter("expires_at", false)]
        public string ExpiresAt { get; set; }

        [RequestParameter("redirect_uri", false)]
        public string RedirectUri { get; set; }

        [RequestParameter("display", false)]
        public DisplayType Display { get; set; }

        [RequestParameter("nofollow", false)]
        public int NoFollow { get; set; }
    }
}
