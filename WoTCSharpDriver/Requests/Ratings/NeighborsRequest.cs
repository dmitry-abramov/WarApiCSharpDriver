using System;
using WarApi.ConstantValues;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Ratings
{
    public class NeighborsRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "neighbors";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }

        [RequestParameter("type", true)]
        public RatingType Type { get; set; }

        [RequestParameter("rank_field", true)]
        public string RankField { get; set; }
        
        [RequestParameter("date", false)]
        public DateTime Date { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }
    }
}
