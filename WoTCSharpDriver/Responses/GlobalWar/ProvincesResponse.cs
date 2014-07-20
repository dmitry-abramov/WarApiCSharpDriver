using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class ProvincesResponseData
    {
        [DataMember(Name = "arena")]
        public string Arena { get; set; }

        [DataMember(Name = "clan_id")]
        public int ClanId { get; set; }

        // todo use ListOrSingel
        [DataMember(Name = "neighbors")]
        public string Neighbors { get; set; }

        [DataMember(Name = "primary_region")]
        public string PrimaryRegion { get; set; }

        [DataMember(Name = "prime_time")]
        public int PrimeTime { get; set; }

        [DataMember(Name = "province_i18n")]
        public string ProvinceName { get; set; }

        [DataMember(Name = "province_id")]
        public string ProvinceId { get; set; }

        [DataMember(Name = "revenue")]
        public int Revenue { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "vehicle_max_level")]
        public int VehicleMaxLevel { get; set; }

        [DataMember(Name = "regions")]
        public IList<Region> Regions { get; set; }
    }

    [DataContract]
    public class ProvincesResponse : ResponseBase<IList<ProvincesResponseData>>
    {
    }
}
