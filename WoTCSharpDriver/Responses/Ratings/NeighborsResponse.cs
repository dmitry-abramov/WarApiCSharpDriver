using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.Ratings
{
    // todo maybe we should use one class for
    // NeighborsResponse, PlayerRatingsResponse and TopPlayersResponse
    public class NeighborsResponse : ResponseBase<IList<PlayerRatingsData>>
    {
    }
}
