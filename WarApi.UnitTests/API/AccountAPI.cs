using System;
using WarApi.ConstantValues;
using WarApi.Requests.Account;
using WarApi.Responses.Account;
using Xunit;

namespace WarApi.UnitTests.API
{
    public class AccountAPI : APITestsBase
    {
        [Fact]
        public void PlayersListRequestTest()
        {
            var request = Client.CreateRequest<PlayersListRequest>();
            request.Search = "gol";
            request.Limit = 20;
            request.Language = Language.Russian;

            var response = Client.GetResponseFor<PlayersListResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.Null(response.Error);
            Assert.Equal(20, response.MetaData.Count);
            Assert.NotNull(string.IsNullOrEmpty(response.Data[0].AccountId));
            Assert.NotNull(string.IsNullOrEmpty(response.Data[0].Nickname));
        }

        [Fact]
        public void PlayersTanksRequestTest()
        {
            var request = Client.CreateRequest<PlayerTanksRequest>();
            request.AccountId = "2989679";
            request.Language = Language.Russian;

            var response = Client.GetResponseFor<PlayerTanksResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.Null(response.Error);
            Assert.True(response.MetaData.Count > 0);
            Assert.NotNull(response.Data["2989679"][0].TankId);
            Assert.NotNull(response.Data["2989679"][0].Statistic);
            Assert.True(response.Data["2989679"][0].Statistic.Battles > 0);
            Assert.True(response.Data["2989679"][0].Statistic.Wins > 0);
        }

        [Fact]
        public void PlayerAchievementsRequestTest()
        {
            var request = Client.CreateRequest<PlayerAchivementsRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<PlayerAchivementsResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.Null(response.Error);
            Assert.True(response.MetaData.Count > 0);
            Assert.True(response.Data["2989679"]["achievements"].Keys.Count > 0);
            Assert.True(response.Data["2989679"]["max_series"].Keys.Count > 0);
        }

        [Fact]
        public void PlayerInfoRequestTest()
        {
            var request = Client.CreateRequest<PlayerInfoRequest>();
            request.AccountId = "2989679";

            var response = Client.GetResponseFor<PlayerInfoResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.Null(response.Error);
            Assert.True(response.MetaData.Count > 0);
            Assert.Equal(response.Data["2989679"].AccountId, "2989679");
            Assert.Equal(response.Data["2989679"].ClanId, null);
            Assert.Equal(new DateTime(2011, 8, 15, 8, 42, 30), response.Data["2989679"].CreatedAt);
            Assert.Equal(Language.Russian, response.Data["2989679"].ClientLanguage);
            Assert.NotNull(response.Data["2989679"].Statistics);
            Assert.NotNull(response.Data["2989679"].Statistics.All);
            Assert.NotNull(response.Data["2989679"].Statistics.Clan);
            Assert.NotNull(response.Data["2989679"].Statistics.Company);
            Assert.NotNull(response.Data["2989679"].Statistics.Historical);
        }

        [Fact]
        public void PlayerInfoRequestForTwoPlayersTest()
        {
            var request = Client.CreateRequest<PlayerInfoRequest>();
            request.AccountId = "2989679";
            request.AccountId.Add("2989680");

            var response = Client.GetResponseFor<PlayerInfoResponse>(request);

            Assert.Equal("ok", response.Status);
            Assert.Null(response.Error);
            Assert.True(response.MetaData.Count > 0);
            Assert.Equal(response.Data["2989679"].AccountId, "2989679");
            Assert.Equal(response.Data["2989679"].ClanId, null);
            Assert.Equal(response.Data["2989679"].CreatedAt, new DateTime(2011, 8, 15, 8, 42, 30));
            Assert.NotNull(response.Data["2989679"].Statistics);
            Assert.NotNull(response.Data["2989679"].Statistics.All);
            Assert.NotNull(response.Data["2989679"].Statistics.Clan);
            Assert.NotNull(response.Data["2989679"].Statistics.Company);
            Assert.NotNull(response.Data["2989679"].Statistics.Historical);

            Assert.Equal("ok", response.Status);
            Assert.NotNull(response.Data["2989680"]);
        }
    }
}
