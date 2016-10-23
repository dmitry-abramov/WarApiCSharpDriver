using System;
using WarApi.ConstantValues;
using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Ratings
{
    public class PlayerRatingsRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "accounts";
            }
        }

        [RequestParameter("account_id", true)]
        public ListOrSingleValue<string> AccountId { get; set; }

        [RequestParameter("type", true)]
        public RatingType Type { get; set; }

        [RequestParameter("date", true)]
        public DateTime Date { get; set; }
    }
}
