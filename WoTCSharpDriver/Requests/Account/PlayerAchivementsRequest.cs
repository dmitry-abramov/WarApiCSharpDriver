using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Account
{
    public class PlayerAchivementsRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "achievements";
            }
        }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }
    }
}
