namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetRoleMappingsForGroupAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRoleMappingsForGroupAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRealmRoleMappingsForGroupAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetRealmRoleMappingsForGroupAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAvailableRealmRoleMappingsForGroupAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForGroupAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetEffectiveRealmRoleMappingsForGroupAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForGroupAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRoleMappingsForUserAsync()
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRoleMappingsForUserAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRealmRoleMappingsForUserAsync()
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetRealmRoleMappingsForUserAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetAvailableRealmRoleMappingsForUserAsync()
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetAvailableRealmRoleMappingsForUserAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetEffectiveRealmRoleMappingsForUserAsync()
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetEffectiveRealmRoleMappingsForUserAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }
    }
}
