namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetGroupHierarchyAsync()
        {
            var result = await _client.GetGroupHierarchyAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGroupsCountAsync()
        {
            int? result = await _client.GetGroupsCountAsync(RealmId);
            Assert.True(result >= 0);
        }

        [Fact]
        public async Task GetGroupAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetGroupAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }
        
        [Fact]
        public async Task GetGroupClientAuthorizationPermissionsInitializedAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetGroupClientAuthorizationPermissionsInitializedAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetGroupUsersAsync()
        {
            var groups = await _client.GetGroupHierarchyAsync(RealmId);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await _client.GetGroupUsersAsync(RealmId, groupId);
                Assert.NotNull(result);
            }
        }
    }
}
