namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetRoleByIdAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAsync(RealmId, roleId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRoleChildrenAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleChildrenAsync(RealmId, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-client-1")]
        public async Task GetClientRolesForCompositeByIdAsync(string clientId)
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var clients = await _client.GetClientsAsync(RealmId);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientsId != null)
                {
                    var result = await _client.GetClientRolesForCompositeByIdAsync(RealmId, roleId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Fact]
        public async Task GetRealmRolesForCompositeByIdAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRealmRolesForCompositeByIdAsync(RealmId, roleId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRoleByIdAuthorizationPermissionsInitializedAsync()
        {
            var roles = await _client.GetRolesAsync(RealmId);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAuthorizationPermissionsInitializedAsync(RealmId, roleId);
                Assert.NotNull(result);
            }
        }
    }
}
