using WarApiCSharpDriver.Attributes;
using WarApiCSharpDriver.Requests;

namespace WarApiCSharpDriver.Requests.Account
{
    public class AccountRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "account";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
