using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRolesForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetRolesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleByNameForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleByNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleCompositesForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleCompositesAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetApplicationRolesForCompositeForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetApplicationRolesForCompositeAsync(realm, clientsId, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRealmRolesForCompositeForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRealmRolesForCompositeAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetGroupsWithRoleNameForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetGroupsWithRoleNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleAuthorizationPermissionsInitializedForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetRoleAuthorizationPermissionsInitializedAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetUsersWithRoleNameForClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetUsersWithRoleNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRolesForRealmAsync(string realm)
        {
            var result = await _client.GetRolesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByNameForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleByNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleCompositesForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleCompositesAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetApplicationRolesForCompositeForRealmAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await _client.GetRolesAsync(realm);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await _client.GetApplicationRolesForCompositeAsync(realm, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesForCompositeForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRealmRolesForCompositeAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task GetGroupsWithRoleNameForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetGroupsWithRoleNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleAuthorizationPermissionsInitializedForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetRoleAuthorizationPermissionsInitializedAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersWithRoleNameForRealmAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await _client.GetUsersWithRoleNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }
    }
}
