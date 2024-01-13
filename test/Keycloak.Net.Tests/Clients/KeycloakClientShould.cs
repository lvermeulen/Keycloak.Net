namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetClientsAsync()
        {
            var result = await _client.GetClientsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GenerateClientSecretAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientSecretAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientSecretAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientSecretAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetDefaultClientScopesAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetDefaultClientScopesAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("test-data-client-1")]
        public async Task GenerateClientExampleAccessTokenAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientExampleAccessTokenAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetProtocolMappersInTokenGenerationAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetProtocolMappersInTokenGenerationAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientGrantedScopeMappingsAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientGrantedScopeMappingsAsync(RealmId, clientsId, RealmId);
                Assert.NotNull(result);
                result = await _client.GetClientGrantedScopeMappingsAsync(RealmId, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientNotGrantedScopeMappingsAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientNotGrantedScopeMappingsAsync(RealmId, clientsId, RealmId);
                Assert.NotNull(result);
                result = await _client.GetClientNotGrantedScopeMappingsAsync(RealmId, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("test-data-client-1")]
        public async Task GetClientProviderAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var providerInstances = await _client.GetIdentityProviderInstancesAsync(RealmId);
                string providerInstanceId = providerInstances.FirstOrDefault()?.ProviderId;
                if (providerInstanceId != null)
                {
                    string result = await _client.GetClientProviderAsync(RealmId, clientsId, providerInstanceId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientAuthorizationPermissionsInitializedAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientAuthorizationPermissionsInitializedAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientOfflineSessionCountAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await _client.GetClientOfflineSessionCountAsync(RealmId, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientOfflineSessionsAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientOfflineSessionsAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetOptionalClientScopesAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetOptionalClientScopesAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GenerateClientRegistrationAccessTokenAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientRegistrationAccessTokenAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("test-data-client-1")]
        public async Task GetUserForServiceAccountAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetUserForServiceAccountAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientSessionCountAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await _client.GetClientSessionCountAsync(RealmId, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task TestClientClusterNodesAvailableAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.TestClientClusterNodesAvailableAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientUserSessionsAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientUserSessionsAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetResourcesOwnedByClientAsync(string clientId)
        {
	        var result = await _client.GetResourcesOwnedByClientAsync(RealmId, clientId);
	        Assert.NotNull(result);
        }
    }
}
