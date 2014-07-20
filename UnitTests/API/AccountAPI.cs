using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Serialization;
using WarApiCSharpDriver;
using WarApiCSharpDriver.Requests.Account;
using WarApiCSharpDriver.Responses.Account;

namespace UnitTests.API
{
    [TestClass]
    public class AccountAPI
    {
        private TestWotApplication client;

        private TestWotApplication Client
        {
            get 
            {
                if (client == null)
                {
                    client = new TestWotApplication("demo", "api.worldoftanks.ru", "wot", new NewtonsoftSerializer());
                }

                return client;
            }
        }

        [TestMethod]
        public void PlayersListRequestTest()
        {
            var request = Client.CreateRequest<PlayersListRequest>();
            request.Search = "gol";
            request.Limit = 20;
            request.Language = Language.Russian;

            var response = Client.GetResponseFor<PlayersListResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Error);
            Assert.AreEqual(20, response.Count);
            Assert.IsNotNull(string.IsNullOrEmpty(response.Data[0].AccountId));
            Assert.IsNotNull(string.IsNullOrEmpty(response.Data[0].Nickname));
        }

        [TestMethod]
        public void PlayersTanksRequestTest()
        {
            var request = Client.CreateRequest<PlayerTanksRequest>();
            request.AccountId = "2989679";
            request.Language = Language.Russian;

            var response = Client.GetResponseFor<PlayerTanksResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.Count > 0);
            Assert.IsNotNull(response.Data["2989679"][0].TankId);
            Assert.IsNotNull(response.Data["2989679"][0].Statistic);
            Assert.IsTrue(response.Data["2989679"][0].Statistic.Battles > 0);
            Assert.IsTrue(response.Data["2989679"][0].Statistic.Wins > 0);
        }
    }
}
