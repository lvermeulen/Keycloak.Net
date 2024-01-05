namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId)]
        public async Task GetKeysAsync(string realm)
        {
            var result = await _client.GetKeysAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
