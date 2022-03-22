using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetRoleByIdAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm).ConfigureAwait(false);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAsync(realm, roleId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRoleChildrenAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm).ConfigureAwait(false);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleChildrenAsync(realm, roleId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientRolesForCompositeByIdAsync(string realm, string clientId)
        {
            var roles = await _client.GetRolesAsync(realm).ConfigureAwait(false);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var clients = await _client.GetClientsAsync(realm).ConfigureAwait(false);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientsId != null)
                {
                    var result = await _client.GetClientRolesForCompositeByIdAsync(realm, roleId, clientsId).ConfigureAwait(false);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmRolesForCompositeByIdAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm).ConfigureAwait(false);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRealmRolesForCompositeByIdAsync(realm, roleId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRoleByIdAuthorizationPermissionsInitializedAsync(string realm)
        {
            var roles = await _client.GetRolesAsync(realm).ConfigureAwait(false);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await _client.GetRoleByIdAuthorizationPermissionsInitializedAsync(realm, roleId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
