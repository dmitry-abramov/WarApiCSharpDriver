using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.GlobalWar
{
    public class FamePointsRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "famepoints";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("account_id", true)]
        public ListOrSingleValue<string> AccountId { get; set; }
    }
}
