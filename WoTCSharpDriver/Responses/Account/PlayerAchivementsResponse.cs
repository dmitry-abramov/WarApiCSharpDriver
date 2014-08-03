using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses.Account
{
    //todo: use object
    [DataContract]
    public class PlayerAchivementsResponse : ResponseBase<IDictionary<string, IDictionary<string, IDictionary<string, int>>>>
    {
    }
}
