using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using Utilities.Extensions;

namespace WarApiCSharpDriver.Serialization
{
    public class DateTimeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
            {
                throw new FormatException(
                    String.Format("Unexpected token parsing date. Expected Integer, got {0}.",
                    reader.TokenType));
            }

            var ticks = (long)reader.Value;

            return ticks.ToDateTime();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long ticks;
            if (value is DateTime)
            {
                ticks = ((DateTime)value).ToUnixTime();
            }
            else
            {
                throw new Exception("Expected DateTime object.");
            }
            writer.WriteValue(ticks);
        }
    }
}
