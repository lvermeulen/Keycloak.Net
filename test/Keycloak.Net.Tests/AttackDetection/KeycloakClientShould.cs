namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("test-data-user-1")]
        public async Task GetUserNameStatusInBruteForceDetectionAsync(string search)
        {
            var users = await _client.GetUsersAsync(RealmId, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserNameStatusInBruteForceDetectionAsync(RealmId, userId);
                Assert.NotNull(result);
            }
        }
    }
}
