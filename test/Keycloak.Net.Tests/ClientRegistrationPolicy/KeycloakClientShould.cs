namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId)]
        public async Task GetRetrieveProvidersBasePathAsync(string realm)
        {
            var result = await _client.GetRetrieveProvidersBasePathAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
