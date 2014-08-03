using WarApi.Utilities.Attributes;

namespace WarApi.Requests.GlobalWar
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
