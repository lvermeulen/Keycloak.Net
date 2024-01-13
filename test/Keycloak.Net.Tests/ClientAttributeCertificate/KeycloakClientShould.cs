namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Fact]
        public async Task GetKeyInfoAsync()
        {
            var clients = await _client.GetClientsAsync(RealmId);
            (string clientId, string attribute) = clients
                .Where(x => x.Attributes.Any())
                .Select(client => (client.Id, client.Attributes.FirstOrDefault().Key))
                .FirstOrDefault();
            if (clientId != null)
            {
                var result = await _client.GetKeyInfoAsync(RealmId, clientId, attribute);
                Assert.NotNull(result);
            }
        }
    }
}
