namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetRetrieveProvidersBasePathAsync()
        {
            var result = await _client.GetRetrieveProvidersBasePathAsync(RealmId);
            Assert.NotNull(result);
        }
    }
}
