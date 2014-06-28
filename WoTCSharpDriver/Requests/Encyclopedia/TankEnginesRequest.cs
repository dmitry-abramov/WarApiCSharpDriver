using WoTCSharpDriver.Attributes;


namespace WoTCSharpDriver.Requests.Encyclopedia
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
