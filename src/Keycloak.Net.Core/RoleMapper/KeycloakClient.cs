using Flurl.Http;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<Mapping> GetRoleMappingsForGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings")
            .GetJsonAsync<Mapping>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRoleMappingsToGroupAsync(string realm, string groupId, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
                .PostJsonAsync(roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRoleMappingsForGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> DeleteRealmRoleMappingsFromGroupAsync(string realm, string groupId, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/groups/{groupId}/role-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<Mapping> GetRoleMappingsForUserAsync(string realm, string userId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings")
            .GetJsonAsync<Mapping>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRoleMappingsToUserAsync(string realm, string userId, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
                .PostJsonAsync(roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRoleMappingsForUserAsync(string realm, string userId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> DeleteRealmRoleMappingsFromUserAsync(string realm, string userId, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForUserAsync(string realm, string userId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForUserAsync(string realm, string userId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/role-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);
    }
}
