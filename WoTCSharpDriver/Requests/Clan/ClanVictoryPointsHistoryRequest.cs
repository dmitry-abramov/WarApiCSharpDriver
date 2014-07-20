using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClanVictoryPointsHistoryRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "victorypointshistory";
            }
        }

        [RequestParameter("clan_id", true)]
        public string ClanId { get; set; }

        [RequestParameter("map_id", false)]
        public int MapId { get; set; }

        // todo: use DateTime
        [RequestParameter("since", false)]
        public string Since { get; set; }

        // todo: use DateTime
        [RequestParameter("until", false)]
        public string Until { get; set; }

        [RequestParameter("offset", false)]
        public int Offset { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }
    }
}
