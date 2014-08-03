using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApi.Requests.Account;

namespace UnitTests.Requests.Account
{
    [TestClass]
    public class PlayerInfoTests
    {
        [TestMethod]
        public void GetPath()
        {
            var request = new PlayerInfoRequest();
            var path = request.GetPath();

            Assert.AreEqual("account/info", path);
        }
    }
}
