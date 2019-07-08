using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientScopesAsync(string realm)
        {
            var result = await _client.GetClientScopesAsync(realm);
            Assert.NotNull(result);
        }
    }
}
