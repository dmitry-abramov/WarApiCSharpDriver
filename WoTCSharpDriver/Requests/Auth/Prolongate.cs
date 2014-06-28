using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Auth
{
    public class Prolongate : AuthRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "prolongate";
            }
        }

        // note: use UTC format
        // todo: make DateTime
        [RequestParameter("expires_at", false)]
        public string ExpiresAt { get; set; }
    }
}
