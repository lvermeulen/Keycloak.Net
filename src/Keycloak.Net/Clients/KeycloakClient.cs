using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Clients;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IEnumerable<Client>> GetClientsAsync(string realm, string clientId = null, bool? viewableOnly = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(clientId)] = clientId,
                [nameof(viewableOnly)] = viewableOnly
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Client>>()
                .ConfigureAwait(false);
        }
    }
}
