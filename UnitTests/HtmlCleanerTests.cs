using System;
using WarApi.CodeGenerator;
using Xunit;

namespace UnitTests
{
    public class HtmlCleanerTests
    {
        [Fact]
        public void Clean_SimpleTag_TagDeleted()
        {
            const string html = "<p>Text in html</p>";

            var cleanedText = HtmlCleaner.Clean(html);

            Assert.Equal("Text in html", cleanedText);
        }

        [Fact]
        public void Clean_InnerTag_TagDeleted()
        {
            const string html = "<div>Text before<p>Text in</p>Text after</div>";

            var cleanedText = HtmlCleaner.Clean(html);

            Assert.Equal("Text before" + Environment.NewLine + "Text in" + Environment.NewLine + "Text after", cleanedText);
        }

        [Fact]
        public void Clean_UnorderedList_TextFormatted()
        {
            const string html = "<ul><li>Coffee</li><li>Tea</li><li>Milk</li></ul>";

            var cleanedText = HtmlCleaner.Clean(html);

            Assert.Equal("Coffee" + Environment.NewLine + "Tea" + Environment.NewLine + "Milk", cleanedText);
        }

        [Fact]
        public void Clean_TextWithDuplivatedSpaces_SpacesTrimmed()
        {
            const string html = "<div> Text with   many spaces  </div>";

            var cleanedText = HtmlCleaner.Clean(html);

            Assert.Equal("Text with many spaces", cleanedText);
        }
    }
}
