using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class TankGunsRequest : ModuleInfoRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankguns";
            }
        }

        [RequestParameter("turret_id", false)]
        public string TurretId { get; set; }
    }
}
