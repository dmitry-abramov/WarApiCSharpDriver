using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Account
{
    public class PlayerRatingRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "ratings";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }
    }
}
