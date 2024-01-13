namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetClientScopesAsync()
        {
            var result = await _client.GetClientScopesAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetClientScopeAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }
    }
}
