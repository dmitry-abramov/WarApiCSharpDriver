using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WoTCSharpDriver.Requests;

namespace UnitTests
{
    [TestClass]
    public class RequestBaseTests
    {
        [TestMethod]
        public void GetEmptyParameters()
        {
            var request = new RequestBase();

            var parameters = request.Parameters;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetExceptionForRequiredParameters()
        {
            var request = new RequestBase();

            request.GetParametersLikeUri();
        }

        [TestMethod]
        public void GetParametersForUri()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";

            var uriParameters = request.GetParametersLikeUri();

            Assert.AreEqual("access_token=\"access token\"&application_id=\"application id\"", uriParameters);
        }

        [TestMethod]
        public void GetParametersCreatedWithAddParameter()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";
            request.AddParameter("parameter1", "value1");

            var uriParameters = request.GetParametersLikeUri();

            Assert.AreEqual("parameter1=\"value1\"&access_token=\"access token\"&application_id=\"application id\"", uriParameters);
        }

        [TestMethod]
        public void GetParameterByKey()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.AddParameter("parameter1", "value1");

            var parameter1 = request.GetParameter("parameter1");
            var accessToken = request.GetParameter("access_token");
            var applicationId = request.GetParameter("application_id");

            Assert.IsNull(applicationId);
            Assert.AreEqual("access token", accessToken);
            Assert.AreEqual("value1", parameter1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryGetNotExistParameter()
        {
            var request = new RequestBase();

            var parameter1 = request.GetParameter("parameter1");
        }
    }
}
