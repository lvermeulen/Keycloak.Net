namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId)]
        public async Task GetServerInfoAsync(string realm)
        {
            var result = await _client.GetServerInfoAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RealmId)]
        public async Task CorsPreflightAsync(string realm)
        {
            bool? result = await _client.CorsPreflightAsync(realm);
            Assert.True(result);
        }
    }
}
