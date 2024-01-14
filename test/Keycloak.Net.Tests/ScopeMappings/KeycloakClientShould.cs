namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetScopeMappingsAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetScopeMappingsAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetClientRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetClientRolesForClientScopeAsync(RealmId, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetAvailableClientRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetAvailableClientRolesForClientScopeAsync(RealmId, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetEffectiveClientRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await _client.GetEffectiveClientRolesForClientScopeAsync(RealmId, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetRealmRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetRealmRolesForClientScopeAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAvailableRealmRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetAvailableRealmRolesForClientScopeAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetEffectiveRealmRolesForClientScopeAsync()
        {
            var clientScopes = await _client.GetClientScopesAsync(RealmId);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetEffectiveRealmRolesForClientScopeAsync(RealmId, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetScopeMappingsForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetScopeMappingsForClientAsync(RealmId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetClientRolesScopeMappingsForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetClientRolesScopeMappingsForClientAsync(RealmId, clientId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAvailableClientRolesForClientScopeForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetAvailableClientRolesForClientScopeForClientAsync(RealmId, clientId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetEffectiveClientRolesForClientScopeForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetEffectiveClientRolesForClientScopeForClientAsync(RealmId, clientId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRealmRolesScopeMappingsForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetRealmRolesScopeMappingsForClientAsync(RealmId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAvailableRealmRolesForClientScopeForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetAvailableRealmRolesForClientScopeForClientAsync(RealmId, clientId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetEffectiveRealmRolesForClientScopeForClientAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await _client.GetEffectiveRealmRolesForClientScopeForClientAsync(RealmId, clientId);
                Assert.NotNull(result);
            }
        }
    }
}
