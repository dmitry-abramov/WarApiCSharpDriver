using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
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
        public string ClanId { get; set; }
    }
}
