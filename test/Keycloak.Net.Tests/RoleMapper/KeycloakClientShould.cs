using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm).ConfigureAwait(false);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRoleMappingsForGroupAsync(realm, groupId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm).ConfigureAwait(false);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRealmRoleMappingsForGroupAsync(realm, groupId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetAvailableRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm).ConfigureAwait(false);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForGroupAsync(realm, groupId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetEffectiveRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm).ConfigureAwait(false);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForGroupAsync(realm, groupId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm).ConfigureAwait(false);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRoleMappingsForUserAsync(realm, userId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm).ConfigureAwait(false);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRealmRoleMappingsForUserAsync(realm, userId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetAvailableRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm).ConfigureAwait(false);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForUserAsync(realm, userId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetEffectiveRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm).ConfigureAwait(false);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForUserAsync(realm, userId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
