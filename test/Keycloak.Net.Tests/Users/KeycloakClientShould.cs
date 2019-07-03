using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetUsersAsync()
        {
            var result = await _client.GetUsersAsync("Insurance");
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetUsersCountAsync()
        {
            int result = await _client.GetUsersCountAsync("Insurance");
            Assert.True(result >= 0);
        }
    }
}
