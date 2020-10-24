using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Content;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<Role> GetRoleByIdAsync(string realm, string roleId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}")
            .GetJsonAsync<Role>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateRoleByIdAsync(string realm, string roleId, Role role)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}")
                .PutJsonAsync(role)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRoleByIdAsync(string realm, string roleId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> MakeRoleCompositeAsync(string realm, string roleId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/composites")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRoleChildrenAsync(string realm, string roleId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/composites")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveRolesFromCompositeAsync(string realm, string roleId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/composites")
                .SendJsonAsync(HttpMethod.Delete, new CapturedJsonContent(_serializer.Serialize(roles)))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetClientRolesForCompositeByIdAsync(string realm, string roleId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/composites/clients/{clientId}")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetRealmRolesForCompositeByIdAsync(string realm, string roleId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/composites/realm")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<ManagementPermission> GetRoleByIdAuthorizationPermissionsInitializedAsync(string realm, string roleId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/management/permissions")
            .GetJsonAsync<ManagementPermission>()
            .ConfigureAwait(false);

        public async Task<ManagementPermission> SetRoleByIdAuthorizationPermissionsInitializedAsync(string realm, string roleId, ManagementPermission managementPermission) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles-by-id/{roleId}/management/permissions")
            .PutJsonAsync(managementPermission)
            .ReceiveJson<ManagementPermission>()
            .ConfigureAwait(false);
    }
}
