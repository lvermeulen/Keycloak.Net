namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetClientInitialAccessAsync()
        {
            var result = await _client.GetClientInitialAccessAsync(RealmId);
            Assert.NotNull(result);
        }
    }
}
