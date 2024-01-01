namespace Keycloak.Net
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Flurl.Http;
    using Keycloak.Net.Models.ClientScopes;

    public partial class KeycloakClient
    {
        public async Task<bool> CreateClientScopeAsync(string realm, ClientScope clientScope)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes")
                .PostJsonAsync(clientScope)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ClientScope>> GetClientScopesAsync(string realm)
        {
            return await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes")
            .GetJsonAsync<IEnumerable<ClientScope>>()
            .ConfigureAwait(false);
        }

        public async Task<ClientScope> GetClientScopeAsync(string realm, string clientScopeId)
        {
            return await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
            .GetJsonAsync<ClientScope>()
            .ConfigureAwait(false);
        }

        public async Task<bool> UpdateClientScopeAsync(string realm, string clientScopeId, ClientScope clientScope)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
                .PutJsonAsync(clientScope)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteClientScopeAsync(string realm, string clientScopeId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
