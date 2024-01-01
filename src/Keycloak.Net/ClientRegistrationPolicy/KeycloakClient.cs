namespace Keycloak.Net
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Flurl.Http;
    using Keycloak.Net.Models.Components;

    public partial class KeycloakClient
    {
        public async Task<IEnumerable<ComponentType>> GetRetrieveProvidersBasePathAsync(string realm)
        {
            return await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-registration-policy/providers")
            .GetJsonAsync<IEnumerable<ComponentType>>()
            .ConfigureAwait(false);
        }
    }
}
