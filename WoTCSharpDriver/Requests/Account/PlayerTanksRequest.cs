using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Account
{
    /// <summary>
    /// Method returns details on player's vehicles
    /// </summary>
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
