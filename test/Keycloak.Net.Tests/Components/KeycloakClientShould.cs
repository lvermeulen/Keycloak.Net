using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetComponentsAsync(string realm)
        {
            var result = await _client.GetComponentsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetComponentAsync(string realm)
        {
            var components = await _client.GetComponentsAsync(realm);
            string componentId = components.FirstOrDefault()?.Id;
            if (componentId != null)
            {
                var result = await _client.GetComponentAsync(realm, componentId);
                Assert.NotNull(result);
            }
        }
    }
}
