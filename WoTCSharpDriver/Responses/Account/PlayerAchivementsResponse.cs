using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApi.Responses.Account
{
    //todo: use object
    public class PlayerAchivementsResponse : ResponseBase<IDictionary<string, IDictionary<string, IDictionary<string, int>>>>
    {
    }
}
