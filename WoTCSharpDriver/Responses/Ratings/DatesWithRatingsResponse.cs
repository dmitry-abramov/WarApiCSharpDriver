using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Ratings
{
    // todo use DateTime
    [DataContract]
    public class DatesWithRatingsResponse : ResponseBase<IList<string>>
    {
    }
}
