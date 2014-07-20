using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApiCSharpDriver;
using WarApiCSharpDriver.Requests;

namespace UnitTests
{
    [TestClass]
    public class LanguageTests
    {
        [TestMethod]
        public void ToStringTest()
        {
            var englishLanguage = Language.English;
            var russianLanguage = Language.Russian;
            var germanLanguage = Language.German;

            Assert.AreEqual("en", englishLanguage.ToString());
            Assert.AreEqual("ru", russianLanguage.ToString());
            Assert.AreEqual("de", germanLanguage.ToString());
        }

        [TestMethod]
        public void TestRequest()
        {
            var request = new RequestBase();

            request.ApplicationId = "appId";
            request.Language = Language.English;

            Assert.AreEqual("application_id=appId&language=en", request.GetParametersLikeUri());
        }
    }
}
