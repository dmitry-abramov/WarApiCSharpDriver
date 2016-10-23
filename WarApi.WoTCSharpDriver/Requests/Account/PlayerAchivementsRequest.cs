using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Account
{
    /// <summary>
    /// Method returns players' achievement details.
    /// </summary>
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
        public ListOrSingleValue<string> AccountId { get; set; }
    }
}
