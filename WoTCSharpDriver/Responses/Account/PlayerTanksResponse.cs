using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Account
{
    [DataContract]
    public class PlayerTanksResponseData
    {
        [DataMember(Name = "tank_id")]
        [JsonProperty(PropertyName = "tank_id")]
        public int TankId { get; set; }

        [DataMember(Name = "mark_of_mastery")]
        [JsonProperty(PropertyName = "mark_of_mastery")]
        public int MarkOfMastery { get; set; }
        
        [DataMember(Name = "statistics")]
        [JsonProperty(PropertyName = "statistics")]
        public TankStatistic Statistic { get; set; }
    }

    [DataContract]
    public class PlayerTanksResponse : ResponseBase<IDictionary<string, IList<PlayerTanksResponseData>>>
    {
    }
}
