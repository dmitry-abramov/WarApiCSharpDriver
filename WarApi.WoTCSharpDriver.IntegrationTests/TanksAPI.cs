using WarApi.Requests.Tanks;
using WarApi.Responses.Tanks;
using Xunit;

namespace WarApi.WoTCSharpDriver.IntegrationTests
{
    public class TanksAPI : APITestsBase
    {
        [Fact]
        public void TanksStatisticsRequetstTest()
        {
            var request = Client.CreateRequest<TanksStatisticsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<TanksStatisticsResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.NotNull(response.Data["2989679"][0].All);
            Assert.NotNull(response.Data["2989679"][0].Clan);
            Assert.NotNull(response.Data["2989679"][0].Company);
        }

        [Fact]
        public void TanksAchievementsRequetstTest()
        {
            var request = Client.CreateRequest<TanksAchievementsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<TanksAchivementsResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.NotNull(response.Data["2989679"][0].Achivements);
        }
    }
}
