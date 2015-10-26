using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarApi.ConstantValues;
using WarApi.Requests.Tanks;
using WarApi.Responses.Tanks;

namespace UnitTests.API
{
    [TestClass]
    public class TanksAPI : APITestsBase
    {
        [TestMethod]
        public void TanksStatisticsRequetstTest()
        {
            var request = Client.CreateRequest<TanksStatisticsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<TanksStatisticsResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNotNull(response.Data["2989679"][0].All);
            Assert.IsNotNull(response.Data["2989679"][0].Clan);
            Assert.IsNotNull(response.Data["2989679"][0].Company);
        }

        [TestMethod]
        public void TanksAchievementsRequetstTest()
        {
            var request = Client.CreateRequest<TanksAchievementsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<TanksAchivementsResponse>(request);

            Assert.AreEqual("ok", response.Status);
            Assert.IsNotNull(response.Data["2989679"][0].Achivements);
        }
    }
}
