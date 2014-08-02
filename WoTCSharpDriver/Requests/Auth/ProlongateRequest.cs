using System;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Auth
{
    public class ProlongateRequest : AuthRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "prolongate";
            }
        }

        [RequestParameter("expires_at", false)]
        public DateTime ExpiresAt { get; set; }
    }
}
