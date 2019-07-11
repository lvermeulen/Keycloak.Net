using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByIdAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleChildrenAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleChildrenAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientRolesForCompositeByIdAsync(string realm, string clientId)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var clients = await _client.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientsId != null)
                {
                    var result = await _client.GetClientRolesForCompositeByIdAsync(realm, roleId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesForCompositeByIdAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRealmRolesForCompositeByIdAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByIdAuthorizationPermissionsInitializedAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAuthorizationPermissionsInitializedAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }
    }
}
