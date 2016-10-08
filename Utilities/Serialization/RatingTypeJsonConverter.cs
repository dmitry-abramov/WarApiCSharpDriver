using Newtonsoft.Json;
using System;
using WarApi.ConstantValues;

namespace WarApi.Utilities.Serialization
{
    public class RatingTypeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RatingType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
            {
                throw new FormatException(
                    String.Format("Unexpected token parsing rating type. Expected String, got {0}.",
                    reader.TokenType));
            }

            var typeName = (string)reader.Value;

            return new RatingType(typeName);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is RatingType)
            {
                var abbreviation = ((RatingType)value).Name;
                writer.WriteValue(abbreviation);
            }
            else
            {
                throw new Exception("Expected rating type object.");
            }
        }
    }
}
