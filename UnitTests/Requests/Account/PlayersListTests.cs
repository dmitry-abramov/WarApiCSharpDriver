using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApiCSharpDriver.Requests.Account;

namespace UnitTests.Requests.Account
{
    [TestClass]
    public class PlayersListTests
    {
        [TestMethod]
        public void GetPath()
        {
            var request = new PlayersListRequest();
            var path = request.GetPath();

            Assert.AreEqual("account/list", path);
        }
    }
}
