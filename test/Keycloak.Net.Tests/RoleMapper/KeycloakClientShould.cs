using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await _client.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}
