using WarApiCSharpDriver.Attributes;

namespace WarApiCSharpDriver.Requests.GlobalWar
{
    public class ProvincesRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "provinces";
            }
        }

        [RequestParameter("map_id", true)]
        public int MapId { get; set; }

        [RequestParameter("province_id", false)]
        public string ProvinceId { get; set; }
    }
}
