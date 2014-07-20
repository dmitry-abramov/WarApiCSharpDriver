using WarApiCSharpDriver.Attributes;


namespace WarApiCSharpDriver.Requests.Encyclopedia
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
