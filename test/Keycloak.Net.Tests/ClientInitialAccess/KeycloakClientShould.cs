using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientInitialAccessAsync(string realm)
        {
            var result = await _client.GetClientInitialAccessAsync(realm);
            Assert.NotNull(result);
        }
    }
}
