using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IEnumerable<ComponentType>> GetRetrieveProvidersBasePathAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-registration-policy/providers")
            .GetJsonAsync<IEnumerable<ComponentType>>()
            .ConfigureAwait(false);
    }
}
