using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetResourcesOwnByUserAsync(string realm)
        {
            //memo: we need to add a client which named 'school', give some permission to the user(resources, and scopes)
            var result = await _client.GetAllResourcesOwnByCurrentUser(realm, "school");
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersAsync(string realm)
        {
            var result = await _client.GetUsersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersCountAsync(string realm)
        {
            int? result = await _client.GetUsersCountAsync(realm);
            Assert.True(result >= 0);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUserAsync(string realm)
        {
            var users = await _client.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserAsync(realm, userId);
                Assert.NotNull(result);
                Assert.Equal(userId, result.Id);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserSocialLoginsAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserSocialLoginsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserGroupsAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserGroupsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserGroupsCountAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                int? result = await _client.GetUserGroupsCountAsync(realm, userId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserSessionsAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserSessionsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}
