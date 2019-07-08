using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetKeysAsync(string realm)
        {
            var result = await _client.GetKeysAsync(realm);
            Assert.NotNull(result);
        }
    }
}
