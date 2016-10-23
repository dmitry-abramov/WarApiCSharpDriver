using Newtonsoft.Json;
using WarApi.Utilities.Serialization;
using WarApi.ConstantValues;
using WarApi.Requests;
using Xunit;

namespace WarApi.UnitTests
{
    public class LanguageTests
    {
        [Fact]
        public void ToString_Language_TwoLetterAbbreviation()
        {
            var englishLanguage = Language.English;
            var russianLanguage = Language.Russian;
            var germanLanguage = Language.German;

            Assert.Equal("en", englishLanguage.ToString());
            Assert.Equal("ru", russianLanguage.ToString());
            Assert.Equal("de", germanLanguage.ToString());
        }

        [Fact]
        public void RequestSerialization_LanguageParameter_SerializedAsTwoLetterAbbreviation()
        {
            var request = new RequestBase();

            request.ApplicationId = "appId";
            request.Language = Language.English;

            Assert.Equal("application_id=appId&language=en", request.GetParametersLikeUri());
        }

        [Fact]
        public void Deserialization_AbbreviationString_Language()
        {
            var serializedString = "\"zh-cn\"";

            var result = JsonConvert.DeserializeObject<Language>(serializedString, new LanguageJsonConverter());

            Assert.Equal(Language.Chinese, result);
        }

        [Fact]
        public void SerializationToJson_Language_SerializedWithLocality()
        {
            var language = Language.Chinese;

            var result = JsonConvert.SerializeObject(language, new LanguageJsonConverter());

            Assert.Equal("\"zh-cn\"", result);
        }

        [Fact]
        public void Equal_SameLanguages_Equal()
        {
            var abbreviation = "zh-cn";
            var language = Language.Chinese;

            Assert.True(language.Equals(new Language(abbreviation)));
        }

        [Fact]
        public void Equal_LanguageWithDifferentCases_Equal()
        {
            var abbreviation = "De";
            var language = Language.German;

            Assert.True(language.Equals(new Language(abbreviation)));
        }
    }
}
