using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClanInfoRequest : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "info";
            }


        }

        [RequestParameter("clan_id", true)]
        public string ClanId { get; set; }
    }
}
