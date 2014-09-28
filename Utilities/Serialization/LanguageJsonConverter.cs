using Newtonsoft.Json;
using System;
using WarApi;
using WarApi.ConstantValues;

namespace WarApi.Utilities.Serialization
{
    public class LanguageJsonConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            return objectType == typeof(Language);
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
            {
                throw new FormatException(
                    String.Format("Unexpected token parsing language. Expected String, got {0}.",
                    reader.TokenType));
            }

            var abbreviation = (string)reader.Value;

            return new Language(abbreviation);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Language)
            {
                var abbreviation = ((Language)value).Abbreviation;
                writer.WriteValue(abbreviation);
            }
            else
            {
                throw new Exception("Expected Language object.");
            }
        }
    }
}
