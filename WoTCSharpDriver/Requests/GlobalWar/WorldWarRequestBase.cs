using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.GlobalWar
{
    public class GlobalWarRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "globalwar";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
