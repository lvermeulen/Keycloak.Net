using Flurl.Http;
using Keycloak.Net.Models.Clients;
using Keycloak.Net.Models.ClientScopes;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.RealmsAdmin;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> ImportRealmAsync(string realm, Realm rep, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment("/admin/realms")
                .PostJsonAsync(rep, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Realm>> GetRealmsAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms")
            .GetJsonAsync<IEnumerable<Realm>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<Realm> GetRealmAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}")
            .GetJsonAsync<Realm>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRealmAsync(string realm, Realm rep, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}")
                .PutJsonAsync(rep, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRealmAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<AdminEvent>> GetAdminEventsAsync(string realm, string authClient = null, string authIpAddress = null, string authRealm = null, string authUser = null,
            string dateFrom = null, string dateTo = null, int? first = null, int? max = null,
            IEnumerable<string> operationTypes = null, string resourcePath = null, IEnumerable<string> resourceTypes = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(authClient)] = authClient,
                [nameof(authIpAddress)] = authIpAddress,
                [nameof(authRealm)] = authRealm,
                [nameof(authUser)] = authUser,
                [nameof(dateFrom)] = dateFrom,
                [nameof(dateTo)] = dateTo,
                [nameof(first)] = first,
                [nameof(max)] = max,
                [nameof(operationTypes)] = operationTypes == null ? null : string.Join(",", operationTypes),
                [nameof(resourcePath)] = resourcePath,
                [nameof(resourceTypes)] = resourceTypes == null ? null : string.Join(",", resourceTypes)
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/admin-events")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<AdminEvent>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<bool> DeleteAdminEventsAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/admin-events")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> ClearKeysCacheAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clear-keys-cache")
                .PostAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> ClearRealmCacheAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clear-realm-cache")
                .PostAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> ClearUserCacheAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clear-user-cache")
                .PostAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<Client> BasePathForImportingClientsAsync(string realm, string description, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-description-converter")
            .PostAsync(new StringContent(description), cancellationToken)
            .ReceiveJson<Client>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<IDictionary<string, object>>> GetClientSessionStatsAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-session-stats")
            .GetJsonAsync<IEnumerable<IDictionary<string, object>>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IEnumerable<ClientScope>> GetRealmDefaultClientScopesAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/default-default-client-scopes")
            .GetJsonAsync<IEnumerable<ClientScope>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRealmDefaultClientScopeAsync(string realm, string clientScopeId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-default-client-scopes/{clientScopeId}")
                .PutAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRealmDefaultClientScopeAsync(string realm, string clientScopeId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-default-client-scopes/{clientScopeId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Group>> GetRealmGroupHierarchyAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/default-groups")
            .GetJsonAsync<IEnumerable<Group>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRealmGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-groups/{groupId}")
                .PutAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRealmGroupAsync(string realm, string groupId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-groups/{groupId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ClientScope>> GetRealmOptionalClientScopesAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/default-optional-client-scopes")
            .GetJsonAsync<IEnumerable<ClientScope>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRealmOptionalClientScopeAsync(string realm, string clientScopeId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-optional-client-scopes/{clientScopeId}")
                .PutAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRealmOptionalClientScopeAsync(string realm, string clientScopeId, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/default-optional-client-scopes/{clientScopeId}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Event>> GetEventsAsync(string realm, string client = null, string dateFrom = null, string dateTo = null, int? first = null,
            string ipAddress = null, int? max = null, string type = null, string user = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(client)] = client,
                [nameof(dateFrom)] = dateFrom,
                [nameof(dateTo)] = dateTo,
                [nameof(first)] = first,
                [nameof(max)] = max,
                [nameof(ipAddress)] = ipAddress,
                [nameof(type)] = type,
                [nameof(user)] = user
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/events")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Event>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<bool> DeleteEventsAsync(string realm, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/events")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<RealmEventsConfig> GetRealmEventsProviderConfigurationAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/events/config")
            .GetJsonAsync<RealmEventsConfig>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRealmEventsProviderConfigurationAsync(string realm, RealmEventsConfig rep, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/events/config")
                .PutJsonAsync(rep, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<Group> GetRealmGroupByPathAsync(string realm, string path, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/group-by-path/{path}")
            .GetJsonAsync<Group>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<GlobalRequestResult> RemoveUserSessionsAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/logout-all")
            .PostAsync(new StringContent(""), cancellationToken)
            .ReceiveJson<GlobalRequestResult>()
            .ConfigureAwait(false);

        public async Task<Realm> RealmPartialExportAsync(string realm, bool? exportClients = null, bool? exportGroupsAndRoles = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(exportClients)] = exportClients,
                [nameof(exportGroupsAndRoles)] = exportGroupsAndRoles,
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/partial-export")
                .SetQueryParams(queryParams)
                .PostAsync(new StringContent(""), cancellationToken)
                .ReceiveJson<Realm>()
                .ConfigureAwait(false);
        }

        public async Task<bool> RealmPartialImportAsync(string realm, PartialImport rep, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/partialImport")
                .PostJsonAsync(rep, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<GlobalRequestResult> PushRealmRevocationPolicyAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/push-revocation")
            .PostAsync(new StringContent(""), cancellationToken)
            .ReceiveJson<GlobalRequestResult>()
            .ConfigureAwait(false);

        public async Task<bool> DeleteUserSessionAsync(string realm, string session, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/sessions/{session}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> TestLdapConnectionAsync(string realm, string action = null, string bindCredential = null, string bindDn = null,
            string componentId = null, string connectionTimeout = null, string connectionUrl = null, string useTruststoreSpi = null, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/testLDAPConnection")
                .PostMultipartAsync(content => content
                    .AddString(nameof(action), action)
                    .AddString(nameof(bindCredential), bindCredential)
                    .AddString(nameof(bindDn), bindDn)
                    .AddString(nameof(componentId), componentId)
                    .AddString(nameof(connectionTimeout), connectionTimeout)
                    .AddString(nameof(connectionUrl), connectionUrl)
                    .AddString(nameof(useTruststoreSpi), useTruststoreSpi), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> TestSmtpConnectionAsync(string realm, string config, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/testSMTPConnection/{config}")
                .PostAsync(new StringContent(""), cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<ManagementPermission> GetRealmUsersManagementPermissionsAsync(string realm, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users-management-permissions")
            .GetJsonAsync<ManagementPermission>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<ManagementPermission> UpdateRealmUsersManagementPermissionsAsync(string realm, ManagementPermission managementPermission, CancellationToken cancellationToken = default)
        {
            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users-management-permissions")
                .PutJsonAsync(managementPermission, cancellationToken)
                .ReceiveJson<ManagementPermission>()
                .ConfigureAwait(false);
        }
    }
}
