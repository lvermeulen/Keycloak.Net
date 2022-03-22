using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetRetrieveProvidersBasePathAsync(string realm)
        {
            var result = await _client.GetRetrieveProvidersBasePathAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
