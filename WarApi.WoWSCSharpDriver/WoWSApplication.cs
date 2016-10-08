using WarApi.Client;
using WarApi.Utilities.Serialization;

namespace WarApi.WoWSCSharpDriver
{
    public class WoWSApplication : WarApiClientBase
    {
        public WoWSApplication(string applicationId) 
            : this(applicationId, new NewtonsoftSerializer())
        {            
        }

        public WoWSApplication(string applicationId, ISerializer serializer)
            : this(applicationId, "api.worldofwarships.ru", "wows", serializer)
        {
        }

        public WoWSApplication(string applicationId, string server, string apiName) 
            : this(applicationId, server, apiName, new NewtonsoftSerializer())
        {
        }

        public WoWSApplication(string applicationId, string server, string apiName, ISerializer serializer)
            : base(applicationId, server, apiName, serializer)
        {
        }
    }
}
