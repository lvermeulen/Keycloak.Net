using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRolesAsync(string realm)
        {
            var result = await _client.GetRolesAsync(realm);
            Assert.NotNull(result);
        }
    }
}
