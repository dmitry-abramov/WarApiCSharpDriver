using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.Tanks
{
    [DataContract]
    public class TanksAchivementsData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("TankId")]
        public string TankId { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("max_series")]
        public string MaxSeries { get; set; }

        [JsonProperty("achivements")]
        public string Achivements { get; set; }
    }

    [DataContract]
    public class TanksAchivementsResponse : ResponseBase<IDictionary<string, TanksAchivementsData>>
    { 
    }
}
