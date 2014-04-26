using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoTCSharpDriver.Requests.Account;

namespace UnitTests.Requests.Account
{
    [TestClass]
    public class PlayerInfoTests
    {
        [TestMethod]
        public void GetPath()
        {
            var request = new PlayerInfo();
            var path = request.GetPath();

            Assert.AreEqual("account/info", path);
        }
    }
}
