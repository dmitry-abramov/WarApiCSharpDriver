using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Encyclopedia
{
    public class TankInfoRequest : EncyclopediaRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankinfo";
            }
        }

        [RequestParameter("tank_id", true)]
        public ListOrSingleValue<string> TankId { get; set; }
    }
}
