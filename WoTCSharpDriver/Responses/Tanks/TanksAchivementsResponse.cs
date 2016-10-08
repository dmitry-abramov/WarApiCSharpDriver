using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.Tanks
{
    public class TanksAchivementsData
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("tank_id")]
        public string TankId { get; set; }

        //todo: add constants or object
        [JsonProperty("series")]
        public IDictionary<string, string> Series { get; set; }

        //todo: add constants or object
        [JsonProperty("max_series")]
        public IDictionary<string, string> MaxSeries { get; set; }

        //todo: add constants or object
        [JsonProperty("achievements")]
        public IDictionary<string, string> Achivements { get; set; }
    }

    public class TanksAchivementsResponse : ResponseBase<IDictionary<string, IList<TanksAchivementsData>>>
    { 
    }
}
