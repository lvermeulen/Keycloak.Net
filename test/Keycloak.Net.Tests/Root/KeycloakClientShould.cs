namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetServerInfoAsync()
        {
            var result = await _client.GetServerInfoAsync(RealmId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CorsPreflightAsync()
        {
            bool? result = await _client.CorsPreflightAsync(RealmId);
            Assert.True(result);
        }
    }
}
