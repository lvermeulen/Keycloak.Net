using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
	    [Theory]
        [InlineData("master")]
	    public async Task GetRealmsAsync(string realm)
	    {
		    var result = await _client.GetRealmsAsync(realm).ConfigureAwait(false);
		    Assert.NotNull(result);
	    }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmAsync(string realm)
        {
            var result = await _client.GetRealmAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetAdminEventsAsync(string realm)
        {
            var result = await _client.GetAdminEventsAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetClientSessionStatsAsync(string realm)
        {
            var result = await _client.GetClientSessionStatsAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmDefaultClientScopesAsync(string realm)
        {
            var result = await _client.GetRealmDefaultClientScopesAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmGroupHierarchyAsync(string realm)
        {
            var result = await _client.GetRealmGroupHierarchyAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmOptionalClientScopesAsync(string realm)
        {
            var result = await _client.GetRealmOptionalClientScopesAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetEventsAsync(string realm)
        {
            var result = await _client.GetEventsAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmEventsProviderConfigurationAsync(string realm)
        {
            var result = await _client.GetRealmEventsProviderConfigurationAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmGroupByPathAsync(string realm)
        {
            var groups = await _client.GetRealmGroupHierarchyAsync(realm).ConfigureAwait(false);
            string path = groups.FirstOrDefault()?.Path;
            if (path != null)
            {
                var result = await _client.GetRealmGroupByPathAsync(realm, path).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("master")]
        public async Task GetRealmUsersManagementPermissionsAsync(string realm)
        {
            var result = await _client.GetRealmUsersManagementPermissionsAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
