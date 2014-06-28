namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class TankChassisRequest : ModuleInfoRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankchassis";
            }
        }
    }
}
