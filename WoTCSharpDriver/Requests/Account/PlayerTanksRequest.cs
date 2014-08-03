using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Account
{
    public class PlayerTanksRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tanks";
            }
        }

        [RequestParameter("account_id", true)]
        public ListOrSingleValue<string> AccountId { get; set; }

        [RequestParameter("tank_id", false)]
        public ListOrSingleValue<string> TankId { get; set; }
    }
}
