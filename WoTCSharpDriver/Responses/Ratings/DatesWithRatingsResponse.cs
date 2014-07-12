using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Ratings
{
    // todo use DateTime
    [DataContract]
    public class DatesWithRatingsResponse : ResponseBase<IList<string>>
    {
    }
}
