namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
	    [Fact]
        public async Task GetRealmsAsync()
	    {
		    var result = await _client.GetRealmsAsync(RealmId);
		    Assert.NotNull(result);
	    }

        [Fact]
        public async Task GetRealmAsync()
        {
            var result = await _client.GetRealmAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAdminEventsAsync()
        {
            var result = await _client.GetAdminEventsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetClientSessionStatsAsync()
        {
            var result = await _client.GetClientSessionStatsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRealmDefaultClientScopesAsync()
        {
            var result = await _client.GetRealmDefaultClientScopesAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRealmGroupHierarchyAsync()
        {
            var result = await _client.GetRealmGroupHierarchyAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRealmOptionalClientScopesAsync()
        {
            var result = await _client.GetRealmOptionalClientScopesAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetEventsAsync()
        {
            var result = await _client.GetEventsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRealmEventsProviderConfigurationAsync()
        {
            var result = await _client.GetRealmEventsProviderConfigurationAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRealmGroupByPathAsync()
        {
            var groups = await _client.GetRealmGroupHierarchyAsync(RealmId);
            string path = groups.FirstOrDefault()?.Path;
            if (path != null)
            {
                var result = await _client.GetRealmGroupByPathAsync(RealmId, path);
                Assert.NotNull(result);
            }
        }

        [Fact]
        public async Task GetRealmUsersManagementPermissionsAsync()
        {
            var result = await _client.GetRealmUsersManagementPermissionsAsync(RealmId);
            Assert.NotNull(result);
        }
    }
}
