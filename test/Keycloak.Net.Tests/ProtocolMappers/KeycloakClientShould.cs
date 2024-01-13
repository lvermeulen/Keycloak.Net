namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetProtocolMappersAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetProtocolMappersAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetProtocolMapperAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(RealmId, clientScopeId);
                string protocolMapperId = protocolMappers.FirstOrDefault()?.Id;
                if (protocolMapperId != null)
                {
                    var result = await _client.GetProtocolMapperAsync(RealmId, clientScopeId, protocolMapperId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetProtocolMappersByNameAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(RealmId, clientScopeId);
                string protocol = protocolMappers.FirstOrDefault()?.Name;
                if (protocol != null)
                {
                    var result = await _client.GetProtocolMappersByNameAsync(RealmId, clientScopeId, protocol);
                    Assert.NotNull(result);
                }
            }
        }
    }
}
