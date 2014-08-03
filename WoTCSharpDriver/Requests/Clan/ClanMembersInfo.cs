using Utilities;
using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClanMembersInfo : ClansRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "membersinfo";
            }
        }

        [RequestParameter("member_id", true)]
        public ListOrSingleValue<string> MemberId { get; set; }
    }
}
