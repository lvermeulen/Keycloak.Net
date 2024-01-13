namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetRolesForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetRolesAsync(RealmId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetRoleByNameForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleByNameAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetRoleCompositesForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleCompositesAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetApplicationRolesForCompositeForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetApplicationRolesForCompositeAsync(RealmId, clientsId, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetRealmRolesForCompositeForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRealmRolesForCompositeAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("test-data-client-1")]
        public async Task GetGroupsWithRoleNameForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetGroupsWithRoleNameAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetRoleAuthorizationPermissionsInitializedForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleAuthorizationPermissionsInitializedAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetUsersWithRoleNameForClientAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetUsersWithRoleNameAsync(RealmId, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetRolesForRealmAsync()
        {
            var result = await _client.GetRolesAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRoleByNameForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleByNameAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRoleCompositesForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleCompositesAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetApplicationRolesForCompositeForRealmAsync(string clientId)
        {
            var clients = await _client.GetClientsAsync(RealmId);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(RealmId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetApplicationRolesForCompositeAsync(RealmId, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetRealmRolesForCompositeForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRealmRolesForCompositeAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }

        [Fact(Skip = "Not working yet")]
        public async Task GetGroupsWithRoleNameForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetGroupsWithRoleNameAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRoleAuthorizationPermissionsInitializedForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleAuthorizationPermissionsInitializedAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetUsersWithRoleNameForRealmAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetUsersWithRoleNameAsync(RealmId, roleName);
                Assert.NotNull(result);
            }
        }
    }
}
