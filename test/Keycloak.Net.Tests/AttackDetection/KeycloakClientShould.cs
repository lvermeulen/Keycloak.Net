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
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;

            var result = await _client.GetUserNameStatusInBruteForceDetectionAsync(realm, userId);
            Assert.NotNull(result);
        }
    }
}
