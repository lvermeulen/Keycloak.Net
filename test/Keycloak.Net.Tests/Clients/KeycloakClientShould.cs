using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientsAsync(string realm)
        {
            var result = await _client.GetClientsAsync(realm);
            Assert.NotNull(result);
        }
    }
}
