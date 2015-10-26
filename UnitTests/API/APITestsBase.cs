using Newtonsoft.Json;

using WarApi.Client;
using WarApi.Utilities.Serialization;

namespace UnitTests.API
{
    public class APITestsBase
    {
        private IWarApiApplication client;

        protected IWarApiApplication Client
        {
            get
            {
                if (client == null)
                {
                    var serializer = new NewtonsoftSerializer();
                    serializer.Settings.MissingMemberHandling = MissingMemberHandling.Error;
                    client = new TestWotApplication("demo", "api.worldoftanks.ru", "wot", serializer);
                }

                return client;
            }
        }
    }
}
