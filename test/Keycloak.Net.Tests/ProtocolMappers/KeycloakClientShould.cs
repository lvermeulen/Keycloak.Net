using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetProtocolMappersAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetProtocolMappersAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetProtocolMapperAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(realm, clientScopeId);
                string protocolMapperId = protocolMappers.FirstOrDefault()?.Id;
                if (protocolMapperId != null)
                {
                    var result = await _client.GetProtocolMapperAsync(realm, clientScopeId, protocolMapperId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetProtocolMappersByNameAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(realm, clientScopeId);
                string protocol = protocolMappers.FirstOrDefault()?.Name;
                if (protocol != null)
                {
                    var result = await _client.GetProtocolMappersByNameAsync(realm, clientScopeId, protocol);
                    Assert.NotNull(result);
                }
            }
        }
    }
}
