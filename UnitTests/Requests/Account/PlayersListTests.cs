﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoTCSharpDriver.Requests.Account;

namespace UnitTests.Requests.Account
{
    [TestClass]
    public class PlayersListTests
    {
        [TestMethod]
        public void GetPath()
        {
            var request = new PlayersList();
            var path = request.GetPath();

            Assert.AreEqual("account/list", path);
        }
    }
}
