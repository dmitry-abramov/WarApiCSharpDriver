using System;
using WarApi.Utilities.Attributes;
using WarApi.ConstantVlaues;

namespace WarApi.Requests.Auth
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
                
        [RequestParameter("expires_at", false)]
        public DateTime ExpiresAt { get; set; }

        [RequestParameter("redirect_uri", false)]
        public string RedirectUri { get; set; }

        [RequestParameter("display", false)]
        public DisplayType Display { get; set; }

        //todo: use enum
        [RequestParameter("nofollow", false)]
        public int NoFollow { get; set; }
    }
}
