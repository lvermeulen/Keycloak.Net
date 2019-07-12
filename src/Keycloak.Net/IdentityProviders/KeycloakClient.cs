using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.IdentityProviders;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IEnumerable<IdentityProvider>> GetIdentityProvidersAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances")
            .GetJsonAsync<IEnumerable<IdentityProvider>>()
            .ConfigureAwait(false);
    }
}
