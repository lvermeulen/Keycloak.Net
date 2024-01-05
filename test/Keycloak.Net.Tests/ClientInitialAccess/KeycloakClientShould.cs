namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId)]
        public async Task GetClientInitialAccessAsync(string realm)
        {
            var result = await _client.GetClientInitialAccessAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
