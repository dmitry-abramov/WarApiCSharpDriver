using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WarApi.Utilities.Serialization;
using WarApi;
using WarApi.Requests.Ratings;
using WarApi.Responses.Ratings;
using WarApi.ConstantValues;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests.API
{
    [TestClass]
    public class RatingsAPI
    {
        private TestWotApplication client;

        private TestWotApplication Client
        {
            get
            {
                if (client == null)
                {
                    client = new TestWotApplication("demo", "api.worldoftanks.ru", "wot", new NewtonsoftSerializer());
                }

                return client;
            }
        }

        [TestMethod]
        public void DatesWithRatingsRequestTest()
        {
            var request = Client.CreateRequest<DatesWithRatingsRequest>();
            request.Type = RatingType.All;

            var response = Client.GetResponseFor<DatesWithRatingsResponse>(request);

            Assert.IsTrue(response.Data.ContainsKey(RatingType.All));
            Assert.IsTrue(response.Data[RatingType.All].Dates.Count > 0);
            Assert.AreNotEqual(DateTime.MinValue, response.Data[RatingType.All].Dates[0]);
        }

        [TestMethod]
        public void RatingTypesResponse()
        {
            var request = Client.CreateRequest<RatingsTypesRequest>();

            var response = Client.GetResponseFor<RatingTypesResponse>(request);

            Assert.IsTrue(response.Data.Count > 0);

            Assert.IsTrue(response.Data.ContainsKey(RatingType.All));
            Assert.IsTrue(response.Data.ContainsKey(RatingType.Type1));
            Assert.IsTrue(response.Data.ContainsKey(RatingType.Type7));
            Assert.IsTrue(response.Data.ContainsKey(RatingType.Type28));

            Assert.IsTrue(response.Data[RatingType.All].Threshold > 0);
            Assert.IsTrue(response.Data[RatingType.All].RankFields.Count > 0);
            Assert.AreEqual(RatingType.All, response.Data[RatingType.All].Type);
        }

        [TestMethod]
        public void TestSerializeAsDictionaryKey()
        {
            var serializer = new NewtonsoftSerializer();

            var serialized = serializer.Serialize(new Dictionary<RatingType, string> { { RatingType.All, "now" } });

            serializer.Deserialize<Dictionary<RatingType, string>>(serialized);
        }
    }
}
