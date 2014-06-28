using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Clan
{
    public class ClansListRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "list";
            }
        }

        [RequestParameter("search", true)]
        public string Search { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }

        // todo: create constants
        [RequestParameter("order_by", false)]
        public string OrderBy { get; set; }
    }
}
