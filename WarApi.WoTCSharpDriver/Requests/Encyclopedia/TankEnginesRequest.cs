using WarApi.Utilities.Attributes;


namespace WarApi.Requests.Encyclopedia
{
    public class TankEnginesRequest : ModuleInfoRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankengines";
            }
        }
    }
}
