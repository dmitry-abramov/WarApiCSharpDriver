using WarApiCSharpDriver.Attributes;

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

        // note: use UTC format
        // todo: make DateTime
        [RequestParameter("expires_at", false)]
        public string ExpiresAt { get; set; }
    }
}
