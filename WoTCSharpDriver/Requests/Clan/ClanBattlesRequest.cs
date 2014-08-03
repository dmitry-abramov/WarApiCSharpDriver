using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClanBattlesRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "battles";
            }
        }

        [RequestParameter("clan_id", true)]
        public ListOrSingleValue<string> ClanId { get; set; }

        [RequestParameter("map_id", false)]
        public int MapId { get; set; }
    }
}
