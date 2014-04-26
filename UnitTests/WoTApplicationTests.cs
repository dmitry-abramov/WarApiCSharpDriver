using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WoTCSharpDriver;
using WoTCSharpDriver.Requests.Account;

namespace UnitTests
{
    [TestClass]
    public class WoTApplicationTests
    {
        [TestMethod]
        public void TestGetResponse()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersList>();

            request.Search = "gollazio";

            var response = application.GetResponseAsStringFor(request);
            
            var expectedString = "{\"status\":\"ok\",\"count\":1,\"data\":[{\"nickname\":\"gollazio\",\"id\":2989679,\"account_id\":2989679}]}";
            Assert.AreEqual(expectedString, response);
        }
    }
}
