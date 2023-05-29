using Flurl.Http;
using Keycloak.Net.Models.AuthorizationScopes;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateAuthorizationScopeAsync(string realm, string resourceServerId, AuthorizationScope scope, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{resourceServerId}/authz/resource-server/scope")
                .PostJsonAsync(scope, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<AuthorizationScope>> GetAuthorizationScopesAsync(string realm, string resourceServerId = null,
            bool deep = false, int? first = null, int? max = null, string name = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(deep)] = deep,
                [nameof(first)] = first,
                [nameof(max)] = max,
                [nameof(name)] = name,
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{resourceServerId}/authz/resource-server/scope")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<AuthorizationScope>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<AuthorizationScope> GetAuthorizationScopeAsync(string realm, string resourceServerId, string scopeId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{resourceServerId}/authz/resource-server/scope/{scopeId}")
            .GetJsonAsync<AuthorizationScope>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateAuthorizationScopeAsync(string realm, string resourceServerId, string scopeId, AuthorizationScope scope, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{resourceServerId}/authz/resource-server/scope/{scopeId}")
                .PutJsonAsync(scope, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAuthorizationScopeAsync(string realm, string resourceServerId, string scopeId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{resourceServerId}/authz/resource-server/scope/{scopeId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
