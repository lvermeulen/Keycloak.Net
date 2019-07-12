using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProvidersAsync(string realm)
        {
            var result = await _client.GetIdentityProvidersAsync(realm);
            Assert.NotNull(result);
        }
    }
}
