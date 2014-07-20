using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.GlobalWar
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
