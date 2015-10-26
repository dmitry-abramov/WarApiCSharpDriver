using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Account
{
    /// <summary>
    /// Method returns player details
    /// </summary>
    public class PlayerInfoRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "info";
            }
        }

        [RequestParameter("account_id", true)]
        public ListOrSingleValue<string> AccountId { get; set; }
    }
}
