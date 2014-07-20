using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.GlobalWar
{
    public class ClansRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "clans";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }

        [RequestParameter("page_no", false)]
        public int PageNumber { get; set; }
    }
}
