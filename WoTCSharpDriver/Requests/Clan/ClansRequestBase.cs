using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.Clan
{
    public class ClansRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "clan";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
