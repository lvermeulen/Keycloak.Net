namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetUsersAsync()
        {
            var result = await _client.GetUsersAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetUsersCountAsync()
        {
            int? result = await _client.GetUsersCountAsync(RealmId);
            Assert.True(result >= 0);
        }

        [Fact]
        public async Task GetUserAsync()
        {
            var users = await _client.GetUsersAsync(RealmId);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserAsync(RealmId, userId);
                Assert.NotNull(result);
                Assert.Equal(userId, result.Id);
            }
        }

        [Theory]
        [InlineData("test-data-user-1")]
        public async Task GetUserSocialLoginsAsync(string search)
        {
            var users = await _client.GetUsersAsync(RealmId, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserSocialLoginsAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-user-1")]
        public async Task GetUserGroupsAsync(string search)
        {
            var users = await _client.GetUsersAsync(RealmId, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserGroupsAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("test-data-user-1")]
        public async Task GetUserGroupsCountAsync(string search)
        {
            var users = await _client.GetUsersAsync(RealmId, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                int? result = await _client.GetUserGroupsCountAsync(RealmId, userId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("test-data-user-1")]
        public async Task GetUserSessionsAsync(string search)
        {
            var users = await _client.GetUsersAsync(RealmId, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserSessionsAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }
    }
}
