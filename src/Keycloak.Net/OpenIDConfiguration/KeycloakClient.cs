using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.OpenIDConfiguration;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<OpenIDConfiguration> GetOpenIDConfigurationAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/realms/{realm}/.well-known/openid-configuration")
            .GetJsonAsync<OpenIDConfiguration>(cancellationToken)
            .ConfigureAwait(false);
    }
}
