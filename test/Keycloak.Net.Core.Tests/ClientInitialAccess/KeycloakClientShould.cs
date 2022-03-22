using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetClientInitialAccessAsync(string realm)
        {
            var result = await _client.GetClientInitialAccessAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
