using Utilities;
using Utilities.Attributes;

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
        public ListOrSingleValue<string> ClanId { get; set; }
    }
}
