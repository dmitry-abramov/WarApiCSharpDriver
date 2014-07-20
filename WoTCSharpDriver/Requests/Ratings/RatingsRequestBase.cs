using WarApiCSharpDriver.Requests;
using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Ratings
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
