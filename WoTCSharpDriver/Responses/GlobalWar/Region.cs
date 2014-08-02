using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class Region
    {
        [JsonProperty("region_i18n")]
        public string Name { get; set; }

        [JsonProperty("region_id")]
        public string RegionId { get; set; }
    }
}
