using Flurl.Http;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.IdentityProviders;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IDictionary<string, object>> ImportIdentityProviderAsync(string realm, string input, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/import-config")
            .PostMultipartAsync(content => content.AddFile(Path.GetFileName(input), Path.GetDirectoryName(input)), cancellationToken)
            .ReceiveJson<IDictionary<string, object>>()
            .ConfigureAwait(false);

        public async Task<bool> CreateIdentityProviderAsync(string realm, IdentityProvider identityProvider, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances")
                .PostJsonAsync(identityProvider, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<IdentityProvider>> GetIdentityProviderInstancesAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances")
            .GetJsonAsync<IEnumerable<IdentityProvider>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IdentityProvider> GetIdentityProviderAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
            .GetJsonAsync<IdentityProvider>(cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        /// <see cref="https://github.com/keycloak/keycloak-documentation/blob/master/server_development/topics/identity-brokering/tokens.adoc"/>
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="identityProviderAlias"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityProviderToken> GetIdentityProviderTokenAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/auth/realms/{realm}/broker/{identityProviderAlias}/token")
            .GetJsonAsync<IdentityProviderToken>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateIdentityProviderAsync(string realm, string identityProviderAlias, IdentityProvider identityProvider, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
                .PutJsonAsync(identityProvider, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIdentityProviderAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> ExportIdentityProviderPublicBrokerConfigurationAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/export")
                .GetAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<ManagementPermission> GetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/management/permissions")
            .GetJsonAsync<ManagementPermission>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<ManagementPermission> SetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias, ManagementPermission managementPermission, CancellationToken cancellationToken = default) =>
            await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/management/permissions")
                .PutJsonAsync(managementPermission, cancellationToken)
                .ReceiveJson<ManagementPermission>()
                .ConfigureAwait(false);

        public async Task<IDictionary<string, object>> GetIdentityProviderMapperTypesAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mapper-types")
            .GetJsonAsync<IDictionary<string, object>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> AddIdentityProviderMapperAsync(string realm, string identityProviderAlias, IdentityProviderMapper identityProviderMapper, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers")
                .PostJsonAsync(identityProviderMapper, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<IdentityProviderMapper>> GetIdentityProviderMappersAsync(string realm, string identityProviderAlias, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers")
            .GetJsonAsync<IEnumerable<IdentityProviderMapper>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IdentityProviderMapper> GetIdentityProviderMapperByIdAsync(string realm, string identityProviderAlias, string mapperId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
            .GetJsonAsync<IdentityProviderMapper>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId, IdentityProviderMapper identityProviderMapper, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
                .PutJsonAsync(identityProviderMapper, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IdentityProviderInfo> GetIdentityProviderByProviderIdAsync(string realm, string providerId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/providers/{providerId}")
            .GetJsonAsync<IdentityProviderInfo>(cancellationToken)
            .ConfigureAwait(false);
    }
}
