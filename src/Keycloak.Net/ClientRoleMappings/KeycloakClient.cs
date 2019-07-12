using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> AddClientRoleMappingsToGroupAsync(string realm, string groupId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/clients/{clientId}")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/clients/{clientId}")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> DeleteClientRoleMappingsFromGroupAsync(string realm, string groupId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/clients/{clientId}")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/clients/{clientId}/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/clients/{clientId}/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> AddClientRoleMappingsToUserAsync(string realm, string userId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/clients/{clientId}")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetClientRoleMappingsForUserAsync(string realm, string userId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/clients/{clientId}")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> DeleteClientRoleMappingsFromUserAsync(string realm, string userId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/clients/{clientId}")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableClientRoleMappingsForUserAsync(string realm, string userId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/clients/{clientId}/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveClientRoleMappingsForUserAsync(string realm, string userId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/clients/{clientId}/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);
    }
}
