using System;
using System.Linq;
using WarApi.CodeGenerator.Contracts;
using Xunit;

namespace WarApi.CodeGenerator.IntegrationTests
{
    public class PageParserTests
    {
        private PageParser pageParser;
        private IPageDownloader pageDownloader;

        public PageParserTests()
        {
            pageDownloader = new PageDownloader();
            pageParser = new PageParser(pageDownloader);
        }

        [Fact]
        public void Parse_AccountInfo_ParseCorrect()
        {
            var method = pageParser.Parse(new Uri("https://developers.wargaming.net/api/methods/wot_account_info/?realm=all"));

            Assert.Equal("account", method.Block);
            Assert.Equal("info", method.Name);
            Assert.Equal("Method returns player details.", method.Description);
            Assert.Equal(6, method.RequestParameters.Count());
            Assert.Equal("language", method.RequestParameters.ToList()[1].Name);
            Assert.True(method.RequestParameters.ToList()[0].IsRequired);
            Assert.False(method.RequestParameters.ToList()[4].IsRequired);
            Assert.Equal("string, list", method.RequestParameters.ToList()[4].Type);
                        
            Assert.Equal("timestamp", method.ResponseParameters.Single(p => p.Name.Contains("created_at")).Type);
        }
    }
}
