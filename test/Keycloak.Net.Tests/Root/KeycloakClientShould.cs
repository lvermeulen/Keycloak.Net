using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetServerInfoAsync(string realm)
        {
            var result = await _client.GetServerInfoAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task CorsPreflightAsync(string realm)
        {
            bool result = await _client.CorsPreflightAsync(realm);
            Assert.True(result);
        }
    }
}
