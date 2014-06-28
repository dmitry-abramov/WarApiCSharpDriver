using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class TankInfoRequest : EncyclopediaRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankinfo";
            }
        }

        [RequestParameter("tank_id", true)]
        public string TankId { get; set; }
    }
}
