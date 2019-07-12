using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.ClientScopes;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateClientScopeAsync(string realm, ClientScope clientScope)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes")
                .PostJsonAsync(clientScope)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ClientScope>> GetClientScopesAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes")
            .GetJsonAsync<IEnumerable<ClientScope>>()
            .ConfigureAwait(false);

        public async Task<ClientScope> GetClientScopeAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
            .GetJsonAsync<ClientScope>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateClientScopeAsync(string realm, string clientScopeId, ClientScope clientScope)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
                .PutJsonAsync(clientScope)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteClientScopeAsync(string realm, string clientScopeId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
    }
}
