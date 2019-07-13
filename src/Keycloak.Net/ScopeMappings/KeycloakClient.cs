using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<Mapping> GetScopeMappingsAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings")
            .GetJsonAsync<Mapping>()
            .ConfigureAwait(false);

        public async Task<bool> AddClientRolesToClientScopeAsync(string realm, string clientScopeId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveClientRolesFromClientScopeAsync(string realm, string clientScopeId, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRolesToClientScopeAsync(string realm, string clientScopeId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/realm")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRolesForClientScopeAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveRealmRolesFromClientScopeAsync(string realm, string clientScopeId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRolesForClientScopeAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRolesForClientScopeAsync(string realm, string clientScopeId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<Mapping> GetScopeMappingsForClientAsync(string realm, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings")
            .GetJsonAsync<Mapping>()
            .ConfigureAwait(false);

        public async Task<bool> AddClientRolesScopeMappingToClientAsync(string realm, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/scope-mappings/clients/{clientId}")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetClientRolesScopeMappingsForClientAsync(string realm, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/clients/{clientId}")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveClientRolesFromClientScopeForClientAsync(string realm, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/clients/{clientId}")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableClientRolesForClientScopeForClientAsync(string realm, string clientScopeId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveClientRolesForClientScopeForClientAsync(string realm, string clientScopeId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-scopes/{clientScopeId}/scope-mappings/clients/{clientId}/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> AddRealmRolesScopeMappingToClientAsync(string realm, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/realm")
                .PostJsonAsync(roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRealmRolesScopeMappingsForClientAsync(string realm, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/realm")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveRealmRolesFromClientScopeForClientAsync(string realm, string clientId, IEnumerable<Role> roles)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/realm")
                .SendJsonAsync(HttpMethod.Delete, roles)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetAvailableRealmRolesForClientScopeForClientAsync(string realm, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/realm/available")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetEffectiveRealmRolesForClientScopeForClientAsync(string realm, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/scope-mappings/realm/composite")
            .GetJsonAsync<IEnumerable<Role>>()
            .ConfigureAwait(false);
    }
}
