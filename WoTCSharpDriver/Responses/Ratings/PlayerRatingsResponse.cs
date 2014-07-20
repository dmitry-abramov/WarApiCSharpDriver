using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Ratings
{
    // todo maybe we should use one class for
    // NeighborsResponse, PlayerRatingsResponse and TopPlayersResponse
    [DataContract]
    public class PlayerRatingsResponse : ResponseBase<IList<PlayerRatingsData>>
    {
    }
}
