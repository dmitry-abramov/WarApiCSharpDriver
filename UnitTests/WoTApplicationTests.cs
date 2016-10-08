using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApi.Client;
using WarApi.Requests.Account;
using WarApi.Responses.Account;

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
    }
}

