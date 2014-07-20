using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Ratings
{
    public class DatesWithRatingsRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "dates";
            }
        }

        // todo: create constants for it
        [RequestParameter("type", true)]
        public string Type { get; set; }
    }
}
