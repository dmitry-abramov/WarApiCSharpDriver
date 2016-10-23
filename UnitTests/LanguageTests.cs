using Newtonsoft.Json;
using WarApi.Utilities.Serialization;
using WarApi.ConstantValues;
using WarApi.Requests;
using Xunit;

namespace UnitTests
{
    public class LanguageTests
    {
        [Fact]
        public void ToStringTest()
        {
            var englishLanguage = Language.English;
            var russianLanguage = Language.Russian;
            var germanLanguage = Language.German;

            Assert.Equal("en", englishLanguage.ToString());
            Assert.Equal("ru", russianLanguage.ToString());
            Assert.Equal("de", germanLanguage.ToString());
        }

        [Fact]
        public void TestRequest()
        {
            var request = new RequestBase();

            request.ApplicationId = "appId";
            request.Language = Language.English;

            Assert.Equal("application_id=appId&language=en", request.GetParametersLikeUri());
        }

        [Fact]
        public void TestDeserializationFromJson()
        {
            var serializedString = "\"zh-cn\"";
            var expected = Language.Chinese;

            var result = JsonConvert.DeserializeObject<Language>(serializedString, new LanguageJsonConverter());

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSerializationToJson()
        {
            var expected = "\"zh-cn\"";
            var language = Language.Chinese;

            var result = JsonConvert.SerializeObject(language, new LanguageJsonConverter());

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEqual()
        {
            var abbreviation = "zh-cn";
            var language = Language.Chinese;

            Assert.True(language.Equals(new Language(abbreviation)));
        }

        [Fact]
        public void TestEqualToCaseInsensetive()
        {
            var abbreviation = "De";
            var language = Language.German;

            Assert.True(language.Equals(new Language(abbreviation)));
        }
    }
}
