using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClanVictoryPoints : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "victorypoints";
            }
        }

        [RequestParameter("clan_id", true)]
        public ListOrSingleValue<string> ClanId { get; set; }
    }
}
