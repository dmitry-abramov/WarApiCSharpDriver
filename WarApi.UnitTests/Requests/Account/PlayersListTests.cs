using WarApi.Requests.Account;
using Xunit;

namespace WarApi.UnitTests.Requests.Account
{
    public class PlayersListTests
    {
        [Fact]
        public void GetPath()
        {
            var request = new PlayersListRequest();
            var path = request.GetPath();

            Assert.Equal("account/list", path);
        }
    }
}
