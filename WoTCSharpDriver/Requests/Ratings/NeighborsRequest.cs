using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Ratings
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

        // todo: create constants for it
        [RequestParameter("type", true)]
        public string Type { get; set; }

        [RequestParameter("rank_field", true)]
        public string RankField { get; set; }
        
        // todo: use DateTime
        [RequestParameter("date", false)]
        public string Date { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }
    }
}
