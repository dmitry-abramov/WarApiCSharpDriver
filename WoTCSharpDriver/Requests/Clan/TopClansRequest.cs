using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class TopClansRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "top";
            }
        }

        [RequestParameter("map_id", false)]
        public int MapId { get; set; }

        // note: current_season or current_step
        // todo: create consts
        [RequestParameter("time", false)]
        public string Time { get; set; }
    }
}
