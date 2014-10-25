using System;

using WarApi.Client;
using WarApi.Utilities.Serialization;

namespace WarApi.WoWPCSharpDriver
{
    public class WoWPApplication : WarApiClientBase
    {
        public WoWPApplication(string applicationId) 
            : this(applicationId, new NewtonsoftSerializer())
        {            
        }

        public WoWPApplication(string applicationId, ISerializer serializer)
            : this(applicationId, "api.worldofwarplanes.ru", "wowp", serializer)
        {
        }

        public WoWPApplication(string applicationId, string server, string apiName) 
            : this(applicationId, server, apiName, new NewtonsoftSerializer())
        {
        }

        public WoWPApplication(string applicationId, string server, string apiName, ISerializer serializer)
            : base(applicationId, server, apiName, serializer)
        {
        }
    }
}
