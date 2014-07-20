using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Tanks
{
    [DataContract]
    public class TanksAchivementsData
    {
        [DataMember(Name = "account_id")]
        public string AccountId { get; set; }

        [DataMember(Name = "TankId")]
        public string TankId { get; set; }

        [DataMember(Name = "series")]
        public string Series { get; set; }

        [DataMember(Name = "max_series")]
        public string MaxSeries { get; set; }

        [DataMember(Name = "achivements")]
        public string Achivements { get; set; }
    }

    [DataContract]
    public class TanksAchivementsResponse : ResponseBase<IDictionary<string, TanksAchivementsData>>
    { 
    }
}
