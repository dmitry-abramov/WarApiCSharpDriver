using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApi;
using WarApi.Client;
using WarApi.Requests.Account;
using WarApi.Requests.Clan;
using WarApi.Responses.Account;
using WarApi.Responses.Clan;

namespace UnitTests
{
    [TestClass]
    public class WoTApplicationTests
    {
        [TestMethod]
        public void TestGetResponseAsString()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();

            request.Search = "gollazio";

            var response = application.GetResponseAsStringFor(request);

            var expectedString = "{\"status\":\"ok\",\"meta\":{\"count\":1},\"data\":[{\"nickname\":\"gollazio\",\"account_id\":2989679}]}";
            Assert.AreEqual(expectedString, response);
        }

        [TestMethod]
        public void TestGetResponse()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();

            request.Search = "gollazio";

            var response = application.GetResponseFor<PlayersListResponse>(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(response.MetaData.Count, 1);
            Assert.AreEqual(response.Status, "ok");
            Assert.AreEqual(response.Data[0].Nickname, "gollazio");
            Assert.AreEqual(response.Data[0].AccountId, "2989679");
            Assert.IsNull(response.Data[0].Id);
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void TestRequestWithSpaces()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();
            
            request.Search = "gol lazio";

            var response = application.GetResponseFor<PlayersListResponse>(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.MetaData.Count);
            Assert.AreEqual(response.Status, "ok");
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        [Ignore]
        public void TestSearchClanRequest()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<ClansListRequest>();

            request.Search = "virtus";
            request.Limit = 1;

            var response = application.GetResponseFor<ClanListResponse>(request);

            Assert.IsNotNull(response);
            Assert.IsNull(response.MetaData);
            Assert.AreEqual(response.Status, "ok");
            Assert.IsNull(response.Error);
            
            Assert.AreEqual(response.Data[0].Abbreviation, "VIRT");
            Assert.AreEqual(response.Data[0].CreatedAt, "1297894124");
            Assert.AreEqual(response.Data[0].Emblems.EmblemOnTank.ToString(), "http://clans.worldoftanks.ru/media/clans/emblems/cl_319/2319/emblem_64x64_tank.png");
        }
    }
}

