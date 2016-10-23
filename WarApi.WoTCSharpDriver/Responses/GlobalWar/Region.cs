using Newtonsoft.Json;

namespace WarApi.Responses.GlobalWar
{
    public class Region
    {
        [JsonProperty("region_i18n")]
        public string Name { get; set; }

        [JsonProperty("region_id")]
        public string RegionId { get; set; }
    }
}
