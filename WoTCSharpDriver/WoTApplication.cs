using WarApi.Utilities.Serialization;

namespace WarApi.Client
{
    public class WoTApplication : WarApiClientBase
    {
        public WoTApplication(string applicationId) 
            : this(applicationId, new NewtonsoftSerializer())
        {            
        }

        public WoTApplication(string applicationId, ISerializer serializer)
            : this(applicationId, "api.worldoftanks.ru", "wot", serializer)
        {
        }

        public WoTApplication(string applicationId, string server, string apiName) 
            : this(applicationId, server, apiName, new NewtonsoftSerializer())
        {
        }

        public WoTApplication(string applicationId, string server, string apiName, ISerializer serializer)
            : base(applicationId, server, apiName, serializer)
        {
        }
    }
}

