using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.GlobalWar
{
    public class ProvincesResponseData
    {
        [JsonProperty("arena")]
        public string Arena { get; set; }

        [JsonProperty("clan_id")]
        public int ClanId { get; set; }

        // todo use ListOrSingel
        [JsonProperty("neighbors")]
        public string Neighbors { get; set; }

        [JsonProperty("primary_region")]
        public string PrimaryRegion { get; set; }

        [JsonProperty("prime_time")]
        public int PrimeTime { get; set; }

        [JsonProperty("province_i18n")]
        public string ProvinceName { get; set; }

        [JsonProperty("province_id")]
        public string ProvinceId { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("vehicle_max_level")]
        public int VehicleMaxLevel { get; set; }

        [JsonProperty("regions")]
        public IList<Region> Regions { get; set; }
    }

    public class ProvincesResponse : ResponseBase<IList<ProvincesResponseData>>
    {
    }
}
