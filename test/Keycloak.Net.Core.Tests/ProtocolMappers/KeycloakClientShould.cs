using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetProtocolMappersAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm).ConfigureAwait(false);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetProtocolMappersAsync(realm, clientScopeId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetProtocolMapperAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm).ConfigureAwait(false);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(realm, clientScopeId).ConfigureAwait(false);
                string protocolMapperId = protocolMappers.FirstOrDefault()?.Id;
                if (protocolMapperId != null)
                {
                    var result = await _client.GetProtocolMapperAsync(realm, clientScopeId, protocolMapperId).ConfigureAwait(false);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetProtocolMappersByNameAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm).ConfigureAwait(false);
            string clientScopeId = clientScopes.FirstOrDefault(x => x.ProtocolMappers != null && x.ProtocolMappers.Any())?.Id;
            if (clientScopeId != null)
            {
                var protocolMappers = await _client.GetProtocolMappersAsync(realm, clientScopeId).ConfigureAwait(false);
                string protocol = protocolMappers.FirstOrDefault()?.Name;
                if (protocol != null)
                {
                    var result = await _client.GetProtocolMappersByNameAsync(realm, clientScopeId, protocol).ConfigureAwait(false);
                    Assert.NotNull(result);
                }
            }
        }
    }
}
