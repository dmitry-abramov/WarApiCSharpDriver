using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Threading;
using WarApi.Client;
using WarApi.Utilities.Serialization;

namespace UnitTests.API
{
    public class APITestsBase
    {
        [TestInitialize]
        public void WaitBeforeTest()
        {
            //waiting before every test to avoid blocking by request per second limit
            Thread.Sleep(500);
        }

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
