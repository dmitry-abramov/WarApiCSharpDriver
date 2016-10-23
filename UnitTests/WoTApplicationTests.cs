using WarApi.Client;
using WarApi.Requests.Account;
using WarApi.Responses.Account;
using Xunit;

namespace UnitTests
{
    public class WoTApplicationTests
    {
        [Fact]
        public void TestGetResponseAsString()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();

            request.Search = "gollazio";

            var response = application.GetResponseAsStringFor(request);

            var expectedString = "{\"status\":\"ok\",\"meta\":{\"count\":1},\"data\":[{\"nickname\":\"gollazio\",\"account_id\":2989679}]}";
            Assert.Equal(expectedString, response);
        }

        [Fact]
        public void TestGetResponse()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();

            request.Search = "gollazio";

            var response = application.GetResponseFor<PlayersListResponse>(request);

            Assert.NotNull(response);
            Assert.Equal(response.MetaData.Count, 1);
            Assert.Equal(response.Status, "ok");
            Assert.Equal(response.Data[0].Nickname, "gollazio");
            Assert.Equal(response.Data[0].AccountId, "2989679");
            Assert.Null(response.Data[0].Id);
            Assert.Null(response.Error);
        }

        [Fact]
        public void TestRequestWithSpaces()
        {
            var application = new WoTApplication("demo", "api.worldoftanks.ru", "wot");

            var request = application.CreateRequest<PlayersListRequest>();
            
            request.Search = "gol lazio";

            var response = application.GetResponseFor<PlayersListResponse>(request);

            Assert.NotNull(response);
            Assert.Equal(0, response.MetaData.Count);
            Assert.Equal(response.Status, "ok");
            Assert.Null(response.Error);
        }
    }
}

