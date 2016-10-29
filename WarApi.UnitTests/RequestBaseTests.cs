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
        public void GetParameters_NoCustomParameters_RequiredParameters()
        {
            var request = new RequestBase();

            var parameters = request.Parameters;

            Assert.Equal(3, parameters.Count);
            Assert.True(parameters.ContainsKey("access_token"));
            Assert.True(parameters.ContainsKey("application_id"));
            Assert.True(parameters.ContainsKey("language"));
        }

        [Fact]
        public void GetParametersLikeUri_RequiredParametersNotSetted_InvalidOperationException()
        {
            var request = new RequestBase();

            Assert.Throws<InvalidOperationException>(() => request.GetParametersLikeUri());
        }

        [Fact]
        public void GetPath_Request_CorrectPath()
        {
            var request = new RequestBase();

            var path = request.GetPath();

            Assert.Equal("MethodBlock/MethodName", path);
        }

        [Fact]
        public void GetParametersLikeUri_RequiredParameters_ParametersUrlEncoded()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [Fact]
        public void GetParametersLikeUri_CustomParameter_ParametersUrlEncoded()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";
            request.AddParameter("parameter1", "value1");

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("parameter1=value1&access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [Fact]
        public void GetParameter_RequiredAndCustomParameters_ParameterValuesReturned()
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
        public void GetParameter_ParameterNotExists_ArgumentException()
        {
            var request = new RequestBase();

            Assert.Throws<ArgumentException>(() => request.GetParameter("parameter1"));
        }

        [Fact]
        public void GetParametersLikeUri_DateParameter_ConvertedToUnixTime()
        {
            var request = new TestRequestWithDateParameter();
            request.ApplicationId = "application id";

            request.Date = new DateTime(2011, 8, 15, 8, 42, 30);

            var uriParameters = request.GetParametersLikeUri();

            Assert.Equal("date=1313397750&application_id=application%20id", uriParameters);
        }
    }
}
