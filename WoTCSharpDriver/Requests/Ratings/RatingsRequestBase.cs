using WoTCSharpDriver.Requests;
using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Ratings
{
    public class RatingsRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "ratings";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
