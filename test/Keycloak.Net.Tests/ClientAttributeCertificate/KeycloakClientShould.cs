using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetKeyInfoAsync(string realm)
        {
            var clients = await _client.GetClientsAsync(realm).ConfigureAwait(false);
            (string clientId, string attribute) = clients
                .Where(x => x.Attributes.Any())
                .Select(client => (client.Id, client.Attributes.FirstOrDefault().Key))
                .FirstOrDefault();
            if (clientId != null)
            {
                var result = await _client.GetKeyInfoAsync(realm, clientId, attribute).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
