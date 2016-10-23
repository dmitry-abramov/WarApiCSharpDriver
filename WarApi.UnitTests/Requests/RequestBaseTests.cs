using System;

using WarApi.Requests;
using WarApi.Utilities.Attributes;
using Xunit;

namespace WarApi.UnitTests
{
    public class RequestBaseTests
    {
        protected class TestRequestWithDateParameter : RequestBase
        {
            [RequestParameter("date", true)]
            public DateTime Date { get; set; }
        }

        [Fact]
        public void GetEmptyParameters()
        {
            var request = new RequestBase();

            var parameters = request.Parameters;
        }

        [Fact]
        public void GetExceptionForRequiredParameters()
        {
            var request = new RequestBase();

            Assert.Throws<InvalidOperationException>(() => request.GetParametersLikeUri());
        }

        [Fact]
        public void GetParametersForUri()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [Fact]
        public void GetParametersCreatedWithAddParameter()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";
            request.AddParameter("parameter1", "value1");

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("parameter1=value1&access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [Fact]
        public void GetParameterByKey()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.AddParameter("parameter1", "value1");

            var parameter1 = request.GetParameter("parameter1");
            var accessToken = request.GetParameter("access_token");
            var applicationId = request.GetParameter("application_id");

            Assert.Null(applicationId);
            Assert.Equal("access token", accessToken);
            Assert.Equal("value1", parameter1);
        }

        [Fact]
        public void TryGetNotExistParameter()
        {
            var request = new RequestBase();

            Assert.Throws<ArgumentException>(() => request.GetParameter("parameter1"));
        }

        [Fact]
        public void TestRequestWithDate()
        {
            var request = new TestRequestWithDateParameter();
            request.ApplicationId = "application id";

            request.Date = new DateTime(2011, 8, 15, 8, 42, 30);

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("date=1313397750&application_id=application%20id", uriParameters);
        }
    }
}
