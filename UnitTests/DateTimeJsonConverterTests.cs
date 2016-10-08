using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WarApi.Utilities.Serialization;

namespace UnitTests
{
    [TestClass]
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

        [TestMethod]
        public void TestDeserialize()
        {
            var serializedValue = "1313397750";

            var deserializedValue = Serializer.Deserialize<DateTime>(serializedValue);

            var expectedValue = new DateTime(2011, 8, 15, 8, 42, 30);
            Assert.AreEqual(expectedValue, deserializedValue);
        }

        [TestMethod]
        public void TestDeserializeAsObject()
        {
            var serializedValue = "1313397750";

            var deserializedValue = Serializer.Deserialize(serializedValue);

            Int64 expectedValue = 1313397750;
            Assert.AreEqual(expectedValue, deserializedValue);
        }

        [TestMethod]
        public void TestSerialize()
        {
            var date = new DateTime(2011, 8, 15, 8, 42, 30); 
            var expectedValue = "1313397750";

            var serializedValue = Serializer.Serialize(date);

            Assert.AreEqual(expectedValue, serializedValue);
        }

        [TestMethod]
        public void TestSerializeDateBeforeEpoch()
        {
            var date = new DateTime(1957, 10, 4, 0, 0, 0);
            var expectedValue = "-386380800";

            var serializedValue = Serializer.Serialize(date);

            Assert.AreEqual(expectedValue, serializedValue);
        }

        [TestMethod]
        public void TestDeserializeDateBeforeEpoch()
        {
            var serializedValue = "-386380800";

            var deserializedValue = Serializer.Deserialize<DateTime>(serializedValue);

            var expectedValue = new DateTime(1957, 10, 4, 0, 0, 0);
            Assert.AreEqual(expectedValue, deserializedValue);
        }
    }
}
