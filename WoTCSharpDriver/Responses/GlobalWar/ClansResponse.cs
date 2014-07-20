using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.GlobalWar
{
    [DataContract]
    public class ClansResponsData
    {
        [DataMember(Name = "clan_id")]
        public int ClanId { get; set; }

        [DataMember(Name = "provinces")]
        public IList<Province> Provinces { get; set; }
    }

    [DataContract]
    public class ClansResponse : ResponseBase<IList<ClansResponsData>>
    {
    }
}
