using WarApi.Utilities;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Clan
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
