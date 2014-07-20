
using System.Runtime.Serialization;
namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class Province
    {
        [DataMember(Name = "occupancy_time")]
        public int OccupancyTime { get; set; }

        [DataMember(Name = "province_i18n")]
        public string Name { get; set; }

        [DataMember(Name = "province_id")]
        public string ProvinceId { get; set; }
    }
}
