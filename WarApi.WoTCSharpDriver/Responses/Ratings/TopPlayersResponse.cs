﻿using System.Collections.Generic;

namespace WarApi.Responses.Ratings
{
    // todo maybe we should use one class for
    // NeighborsResponse, PlayerRatingsResponse and TopPlayersResponse
    public class TopPlayersResponse : ResponseBase<IList<PlayerRatingsData>>
    {
    }
}
