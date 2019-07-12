using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRetrieveProvidersBasePathAsync(string realm)
        {
            var result = await _client.GetRetrieveProvidersBasePathAsync(realm);
            Assert.NotNull(result);
        }
    }
}
