using System;
using WarApi.Utilities.Serialization;
using Xunit;

namespace WarApi.UnitTests
{
    public class DateTimeJsonConverterTests
    {
        private ISerializer serializer;

        public ISerializer Serializer
        {
            get
            {
                if (serializer == null)
                {
                    serializer = new NewtonsoftSerializer();
                }

                return serializer;
            }
        }

        [Fact]
        public void Deserialize_UnixTime_CorrectDateTime()
        {
            var serializedValue = "1313397750";

            var deserializedValue = Serializer.Deserialize<DateTime>(serializedValue);
                        
            Assert.Equal(new DateTime(2011, 8, 15, 8, 42, 30), deserializedValue);
        }

        [Fact]
        public void DeserializeAsObject_UnixTime_CorrectIntValue()
        {
            var serializedValue = "1313397750";

            var deserializedValue = Serializer.Deserialize(serializedValue);

            Assert.Equal((Int64)1313397750, deserializedValue);
        }

        [Fact]
        public void Serialize_DateTime_UnixTimeString()
        {
            var date = new DateTime(2011, 8, 15, 8, 42, 30); 

            var serializedValue = Serializer.Serialize(date);

            Assert.Equal("1313397750", serializedValue);
        }

        [Fact]
        public void Serialize_DateBeforeUnixEpoch_NegativeNumber()
        {
            var date = new DateTime(1957, 10, 4, 0, 0, 0);

            var serializedValue = Serializer.Serialize(date);

            Assert.Equal("-386380800", serializedValue);
        }

        [Fact]
        public void Deserialize_DateBeforeUnixEpoch_CorrectDateTime()
        {
            var serializedValue = "-386380800";

            var deserializedValue = Serializer.Deserialize<DateTime>(serializedValue);

            Assert.Equal(new DateTime(1957, 10, 4, 0, 0, 0), deserializedValue);
        }
    }
}
