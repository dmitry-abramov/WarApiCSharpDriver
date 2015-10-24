using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WarApi.Utilities.Serialization;
using WarApi;
using WarApi.ConstantValues;
using WarApi.Requests.Account;
using WarApi.Responses.Account;
using WarApi.Client;

namespace UnitTests.API
{
    [TestClass]
    public class AccountAPI
    {
        private IWarApiApplication client;

        private IWarApiApplication Client
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
            Assert.AreEqual(20, response.MetaData.Count);
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
            Assert.IsTrue(response.MetaData.Count > 0);
            Assert.IsNotNull(response.Data["2989679"][0].TankId);
            Assert.IsNotNull(response.Data["2989679"][0].Statistic);
            Assert.IsTrue(response.Data["2989679"][0].Statistic.Battles > 0);
            Assert.IsTrue(response.Data["2989679"][0].Statistic.Wins > 0);
        }

        [TestMethod]
        public void PlayerAchievementsRequestTest()
        {
            var request = Client.CreateRequest<PlayerAchivementsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<PlayerAchivementsResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.MetaData.Count > 0);
            Assert.IsTrue(response.Data["2989679"]["achievements"].Keys.Count > 0);
            Assert.IsTrue(response.Data["2989679"]["max_series"].Keys.Count > 0);
        }

        [TestMethod]
        public void PlayerInfoRequestTest()
        {
            var request = Client.CreateRequest<PlayerInfoRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<PlayerInfoResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.MetaData.Count > 0);
            Assert.AreEqual(response.Data["2989679"].AccountId, "2989679");
            Assert.AreEqual(response.Data["2989679"].ClanId, null);
            Assert.AreEqual(new DateTime(2011, 8, 15, 8, 42, 30), response.Data["2989679"].CreatedAt);
            Assert.AreEqual(Language.Russian, response.Data["2989679"].ClientLanguage);
            Assert.IsNotNull(response.Data["2989679"].Statistics);
            Assert.IsNotNull(response.Data["2989679"].Statistics.All);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Clan);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Company);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Historical);
        }

        [TestMethod]
        public void PlayerInfoRequestForTwoPlayersTest()
        {
            var request = Client.CreateRequest<PlayerInfoRequest>();
            request.AccountId = "2989679";
            request.AccountId.Add("2989680");

            var response = Client.GetResponseFor<PlayerInfoResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.MetaData.Count > 0);
            Assert.AreEqual(response.Data["2989679"].AccountId, "2989679");
            Assert.AreEqual(response.Data["2989679"].ClanId, null);
            Assert.AreEqual(response.Data["2989679"].CreatedAt, new DateTime(2011, 8, 15, 8, 42, 30));
            Assert.IsNotNull(response.Data["2989679"].Statistics);
            Assert.IsNotNull(response.Data["2989679"].Statistics.All);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Clan);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Company);
            Assert.IsNotNull(response.Data["2989679"].Statistics.Historical);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNull(response.Data["2989680"], "2989680");
        }
    }
}
