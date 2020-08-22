using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance", "vermeulen")]
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
