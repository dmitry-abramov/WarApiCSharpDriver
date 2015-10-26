using System;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Auth
{
    /// <summary>
    /// Method generates new access_token based on the current token
    /// </summary>
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
