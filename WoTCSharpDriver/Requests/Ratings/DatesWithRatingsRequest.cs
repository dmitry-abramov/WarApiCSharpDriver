using WarApi.ConstantValues;
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

        [RequestParameter("type", true)]
        public RatingType Type { get; set; }

        [RequestParameter("account_id", false)]
        public ListOrSingleValue<string> AccountId { get; set; }
    }
}
