using WarApi.Requests;
using WarApi.Utilities.Attributes;
using WarApi.Utilities;

namespace WarApi.Requests.Tanks
{
    public class TanksRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "tanks";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }

        [RequestParameter("account_id", true)]
        public string AccountId { get; set; }

        [RequestParameter("tank_id", false)]
        public ListOrSingleValue<string> TankId { get; set; }

        [RequestParameter("in_garage", false)]
        public int InGarage { get; set; }
    }
}
