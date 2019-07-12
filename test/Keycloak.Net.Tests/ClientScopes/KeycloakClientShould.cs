using System.Linq;
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

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientScopeAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetClientScopeAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }
    }
}
