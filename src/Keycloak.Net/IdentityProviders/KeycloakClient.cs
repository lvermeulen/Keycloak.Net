using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.IdentityProviders;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IDictionary<string, object>> ImportIdentityProviderAsync(string realm, string input) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/import-config")
            .PostMultipartAsync(content => content.AddFile(Path.GetFileName(input), Path.GetDirectoryName(input)))
            .ReceiveJson<IDictionary<string, object>>()
            .ConfigureAwait(false);

        public async Task<bool> CreateIdentityProviderAsync(string realm, IdentityProvider identityProvider)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances")
                .PostJsonAsync(identityProvider)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<IdentityProvider>> GetIdentityProviderInstancesAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances")
            .GetJsonAsync<IEnumerable<IdentityProvider>>()
            .ConfigureAwait(false);

        public async Task<IdentityProvider> GetIdentityProviderAsync(string realm, string identityProviderAlias) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
            .GetJsonAsync<IdentityProvider>()
            .ConfigureAwait(false);

        /// <summary>
        /// <see cref="https://github.com/keycloak/keycloak-documentation/blob/master/server_development/topics/identity-brokering/tokens.adoc"/>
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="identityProviderAlias"></param>
        /// <returns></returns>
        public async Task<IdentityProviderToken> GetIdentityProviderTokenAsync(string realm, string identityProviderAlias) => await GetBaseUrl(realm)
            .AppendPathSegment($"/auth/realms/{realm}/broker/{identityProviderAlias}/token")
            .GetJsonAsync<IdentityProviderToken>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateIdentityProviderAsync(string realm, string identityProviderAlias, IdentityProvider identityProvider)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
                .PutJsonAsync(identityProvider)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIdentityProviderAsync(string realm, string identityProviderAlias)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ExportIdentityProviderPublicBrokerConfigurationAsync(string realm, string identityProviderAlias)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/export")
                .GetAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
        
        public async Task<ManagementPermission> GetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/management/permissions")
            .GetJsonAsync<ManagementPermission>()
            .ConfigureAwait(false);

        public async Task<ManagementPermission> SetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias, ManagementPermission managementPermission) => 
            await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/management/permissions")
                .PutJsonAsync(managementPermission)
                .ReceiveJson<ManagementPermission>()
                .ConfigureAwait(false);
        
        public async Task<IDictionary<string, object>> GetIdentityProviderMapperTypesAsync(string realm, string identityProviderAlias) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mapper-types")
            .GetJsonAsync<IDictionary<string, object>>()
            .ConfigureAwait(false);

        public async Task<bool> AddIdentityProviderMapperAsync(string realm, string identityProviderAlias, IdentityProviderMapper identityProviderMapper)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers")
                .PostJsonAsync(identityProviderMapper)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
        
        public async Task<IEnumerable<IdentityProviderMapper>> GetIdentityProviderMappersAsync(string realm, string identityProviderAlias) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers")
            .GetJsonAsync<IEnumerable<IdentityProviderMapper>>()
            .ConfigureAwait(false);
        
        public async Task<IdentityProviderMapper> GetIdentityProviderMapperByIdAsync(string realm, string identityProviderAlias, string mapperId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
            .GetJsonAsync<IdentityProviderMapper>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId, IdentityProviderMapper identityProviderMapper)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
                .PutJsonAsync(identityProviderMapper)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/identity-provider/instances/{identityProviderAlias}/mappers/{mapperId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IdentityProviderInfo> GetIdentityProviderByProviderIdAsync(string realm, string providerId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/identity-provider/providers/{providerId}")
            .GetJsonAsync<IdentityProviderInfo>()
            .ConfigureAwait(false);
    }
}
