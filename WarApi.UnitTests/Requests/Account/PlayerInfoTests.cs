using WarApi.Requests.Account;
using Xunit;

namespace WarApi.UnitTests.Requests.Account
{
    public class PlayerInfoTests
    {
        [Fact]
        public void GetPath()
        {
            var request = new PlayerInfoRequest();
            var path = request.GetPath();

            Assert.Equal("account/info", path);
        }
    }
}
