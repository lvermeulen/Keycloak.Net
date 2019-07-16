using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmAsync(string realm)
        {
            var result = await _client.GetRealmAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAdminEventsAsync(string realm)
        {
            var result = await _client.GetAdminEventsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientSessionStatsAsync(string realm)
        {
            var result = await _client.GetClientSessionStatsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmDefaultClientScopesAsync(string realm)
        {
            var result = await _client.GetRealmDefaultClientScopesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmGroupHierarchyAsync(string realm)
        {
            var result = await _client.GetRealmGroupHierarchyAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmOptionalClientScopesAsync(string realm)
        {
            var result = await _client.GetRealmOptionalClientScopesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEventsAsync(string realm)
        {
            var result = await _client.GetEventsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmEventsProviderConfigurationAsync(string realm)
        {
            var result = await _client.GetRealmEventsProviderConfigurationAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmGroupByPathAsync(string realm)
        {
            var groups = await _client.GetRealmGroupHierarchyAsync(realm);
            string path = groups.FirstOrDefault()?.Path;
            if (path != null)
            {
                var result = await _client.GetRealmGroupByPathAsync(realm, path);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmUsersManagementPermissionsAsync(string realm)
        {
            var result = await _client.GetRealmUsersManagementPermissionsAsync(realm);
            Assert.NotNull(result);
        }
    }
}
