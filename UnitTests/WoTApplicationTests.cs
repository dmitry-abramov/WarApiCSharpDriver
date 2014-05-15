using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WoTCSharpDriver;
using WoTCSharpDriver.Requests.Account;
using WoTCSharpDriver.Requests.Clan;
using WoTCSharpDriver.Responses.Account;
using WoTCSharpDriver.Responses.Clan;

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

            var expectedString = "{\"status\":\"ok\",\"count\":1,\"data\":[{\"nickname\":\"gollazio\",\"id\":2989679,\"account_id\":2989679}]}";
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
            Assert.AreEqual(response.Count, 1);
            Assert.AreEqual(response.Status, "ok");
            Assert.AreEqual(response.Data[0].Nickname, "gollazio");
            Assert.AreEqual(response.Data[0].AccountId, "2989679");
            Assert.AreEqual(response.Data[0].Id, "2989679");
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
            Assert.AreEqual(response.Count, 0);
            Assert.AreEqual(response.Status, "ok");
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void TestSearchClanRequest()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<ClansListRequest>();

            request.Search = "virtus";
            request.Limit = 1;

            var response = application.GetResponseFor<ClanListResponse>(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(response.Count, 1);
            Assert.AreEqual(response.Status, "ok");
            Assert.IsNull(response.Error);
            
            Assert.AreEqual(response.Data[0].Abbreviation, "VIRT");
            Assert.AreEqual(response.Data[0].CreatedAt, "1297894124");
            Assert.AreEqual(response.Data[0].Emblems.EmblemOnTank.ToString(), "http://clans.worldoftanks.ru/media/clans/emblems/cl_319/2319/emblem_64x64_tank.png");
        }
    }
}

