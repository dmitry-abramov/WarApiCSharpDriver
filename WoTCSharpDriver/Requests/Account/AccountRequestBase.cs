using WoTCSharpDriver.Attributes;
using WoTCSharpDriver.Requests;

namespace WoTCSharpDriver.Requests.Account
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
