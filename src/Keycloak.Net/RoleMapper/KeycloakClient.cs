using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<Mapping> GetRoleMappingsForGroupAsync(string realm, string groupId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings")
            .GetJsonAsync<Mapping>()
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRoleMappingsToGroupAsync(string realm, string groupId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRoleMappingsForGroupAsync(string realm, string groupId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> DeleteRealmRoleMappingsFromGroupAsync(string realm, string groupId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForGroupAsync(string realm, string groupId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForGroupAsync(string realm, string groupId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<Mapping> GetRoleMappingsForUserAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings")
            .GetJsonAsync<Mapping>()
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRoleMappingsToUserAsync(string realm, string userId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRoleMappingsForUserAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> DeleteRealmRoleMappingsFromUserAsync(string realm, string userId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForUserAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForUserAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);
    }
}
