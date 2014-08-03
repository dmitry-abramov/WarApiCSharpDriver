using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Ratings
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

        [RequestParameter("account_id", true)]
        public ListOrSingleValue<string> AccountId { get; set; }
    }
}
