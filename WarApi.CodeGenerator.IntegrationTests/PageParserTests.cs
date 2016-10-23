using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using WarApi.CodeGenerator.Contracts;

namespace WarApi.CodeGenerator.IntegrationTests
{
    [TestClass]
    public class PageParserTests
    {
        private PageParser pageParser;
        private IPageDownloader pageDownloader;

        [TestInitialize]
        public void Setup()
        {
            pageDownloader = new PageDownloader();
            pageParser = new PageParser(pageDownloader);
        }

        [TestMethod]
        public void Parse_AccountInfo_ParseCorrect()
        {
            var method = pageParser.Parse(new Uri("https://developers.wargaming.net/api/methods/wot_account_info/?realm=all"));

            Assert.AreEqual("account", method.Block);
            Assert.AreEqual("info", method.Name);
            Assert.AreEqual("Method returns player details.", method.Description);
            Assert.AreEqual(6, method.RequestParameters.Count());
            Assert.AreEqual("language", method.RequestParameters.ToList()[1].Name);
            Assert.IsTrue(method.RequestParameters.ToList()[0].IsRequired);
            Assert.IsFalse(method.RequestParameters.ToList()[4].IsRequired);
            Assert.AreEqual("string, list", method.RequestParameters.ToList()[4].Type);
                        
            Assert.AreEqual("timestamp", method.ResponseParameters.Single(p => p.Name.Contains("created_at")).Type);
        }
    }
}
