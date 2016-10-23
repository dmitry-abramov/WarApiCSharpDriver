using WarApi.Utilities.Attributes;
using WarApi.Requests;

namespace WarApi.Requests.Account
{
    /// <summary>
    /// Base class for Account methods
    /// </summary>
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
