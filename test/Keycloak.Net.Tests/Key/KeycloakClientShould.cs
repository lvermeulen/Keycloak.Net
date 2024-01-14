namespace Keycloak.Net.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetKeysAsync()
        {
            var result = await _client.GetKeysAsync(RealmId);
            Assert.NotNull(result);
        }
    }
}
