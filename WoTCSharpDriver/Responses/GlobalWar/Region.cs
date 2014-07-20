using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class Region
    {
        [DataMember(Name = "region_i18n")]
        public string Name { get; set; }

        [DataMember(Name = "region_id")]
        public string RegionId { get; set; }
    }
}
