namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetComponentsAsync()
        {
            var result = await _client.GetComponentsAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetComponentAsync()
        {
            var components = await _client.GetComponentsAsync(RealmId);
            string componentId = components.FirstOrDefault()?.Id;
            if (componentId != null)
            {
                var result = await _client.GetComponentAsync(RealmId, componentId);
                Assert.NotNull(result);
            }
        }
    }
}
