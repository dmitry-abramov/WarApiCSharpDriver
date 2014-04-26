using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WoTCSharpDriver;
using WoTCSharpDriver.Requests.Account;
using WoTCSharpDriver.Responses.Account;

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

            var expected = new PlayersListResponse
            {
                Count = 1,
                Status = "ok",
                Data = new List<PlayersListData>
                {
                    new PlayersListData
                    {
                        Nickname = "gollazio",
                        Id = "2989679",
                        AccountId = "2989679"
                    }
                }
            };

            Assert.IsNotNull(response);
            Assert.AreEqual(response.Count, 1);
            Assert.AreEqual(response.Status, "ok");
            Assert.AreEqual(response.Data[0].Nickname, "gollazio");
            Assert.AreEqual(response.Data[0].AccountId, "2989679");
            Assert.AreEqual(response.Data[0].Id, "2989679");
            Assert.IsNull(response.Error);
        }
    }
}

