using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WarApi.Utilities.Serialization;
using WarApi;
using WarApi.ConstantValues;
using WarApi.Requests;

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

        [TestMethod]
        public void TestDeserializationFromJson()
        {
            var serializedString = "\"zh-cn\"";
            var expected = Language.Chinese;

            var result = JsonConvert.DeserializeObject<Language>(serializedString, new LanguageJsonConverter());

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSerializationToJson()
        {
            var expected = "\"zh-cn\"";
            var language = Language.Chinese;

            var result = JsonConvert.SerializeObject(language, new LanguageJsonConverter());

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestEqual()
        {
            var abbreviation = "zh-cn";
            var language = Language.Chinese;

            Assert.IsTrue(language.Equals(new Language(abbreviation)));
        }

        [TestMethod]
        public void TestEqualToCaseInsensetive()
        {
            var abbreviation = "De";
            var language = Language.German;

            Assert.IsTrue(language.Equals(new Language(abbreviation)));
        }
    }
}
