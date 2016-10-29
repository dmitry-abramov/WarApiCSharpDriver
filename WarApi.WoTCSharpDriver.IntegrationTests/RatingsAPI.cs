using System;
using WarApi.Utilities.Serialization;
using WarApi.Requests.Ratings;
using WarApi.Responses.Ratings;
using WarApi.ConstantValues;
using System.Collections.Generic;
using Xunit;

namespace WarApi.WoTCSharpDriver.IntegrationTests
{
    public class RatingsAPI : APITestsBase
    {
        [Fact]
        public void DatesWithRatingsRequestTest()
        {
            var request = Client.CreateRequest<DatesWithRatingsRequest>();
            request.Type = RatingType.All;

            var response = Client.GetResponseFor<DatesWithRatingsResponse>(request);

            Assert.True(response.Data.ContainsKey(RatingType.All));
            Assert.True(response.Data[RatingType.All].Dates.Count > 0);
            Assert.NotEqual(DateTime.MinValue, response.Data[RatingType.All].Dates[0]);
        }

        [Fact]
        public void RatingTypesResponse()
        {
            var request = Client.CreateRequest<RatingsTypesRequest>();

            var response = Client.GetResponseFor<RatingTypesResponse>(request);

            Assert.True(response.Data.Count > 0);

            Assert.True(response.Data.ContainsKey(RatingType.All));
            Assert.True(response.Data.ContainsKey(RatingType.Type1));
            Assert.True(response.Data.ContainsKey(RatingType.Type7));
            Assert.True(response.Data.ContainsKey(RatingType.Type28));

            Assert.True(response.Data[RatingType.All].Threshold > 0);
            Assert.True(response.Data[RatingType.All].RankFields.Count > 0);
            Assert.Equal(RatingType.All, response.Data[RatingType.All].Type);
        }

        [Fact]
        public void TestSerializeAsDictionaryKey()
        {
            var serializer = new NewtonsoftSerializer();

            var serialized = serializer.Serialize(new Dictionary<RatingType, string> { { RatingType.All, "now" } });

            serializer.Deserialize<Dictionary<RatingType, string>>(serialized);
        }
    }
}
