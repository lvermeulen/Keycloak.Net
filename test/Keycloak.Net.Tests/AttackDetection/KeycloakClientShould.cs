namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId, User)]
        public async Task GetUserNameStatusInBruteForceDetectionAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search).ConfigureAwait(false);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserNameStatusInBruteForceDetectionAsync(realm, userId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
