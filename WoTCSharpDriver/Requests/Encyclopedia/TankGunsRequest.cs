using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Encyclopedia
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
