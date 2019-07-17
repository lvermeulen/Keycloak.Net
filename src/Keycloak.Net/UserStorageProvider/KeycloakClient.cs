using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.UserStorageProvider;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        [Obsolete("Not working yet")]
        public async Task<bool> RemoveImportedUsersAsync(string realm, string storageProviderId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/user-storage/{storageProviderId}/remove-imported-users")
                .PostAsync(new StringContent(""))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        [Obsolete("Not working yet")]
        public async Task<SynchronizationResult> TriggerUserSynchronizationAsync(string realm, string storageProviderId, UserSyncActions action) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/user-storage/{storageProviderId}/sync")
            .SetQueryParam(nameof(action), action == UserSyncActions.Full ? "triggerFullSync" : "triggerChangedUsersSync")
            .PostAsync(new StringContent(""))
            .ReceiveJson<SynchronizationResult>()
            .ConfigureAwait(false);

        [Obsolete("Not working yet")]
        public async Task<bool> UnlinkImportedUsersAsync(string realm, string storageProviderId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/user-storage/{storageProviderId}/unlink-users")
                .PostAsync(new StringContent(""))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        [Obsolete("Not working yet")]
        public async Task<SynchronizationResult> TriggerLdapMapperSynchronizationAsync(string realm, string storageProviderId, string mapperId, LdapMapperSyncActions direction) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/user-storage/{storageProviderId}/mappers/{mapperId}/sync")
            .SetQueryParam(nameof(direction), direction == LdapMapperSyncActions.FedToKeycloak ? "fedToKeycloak" : "keycloakToFed")
            .PostAsync(new StringContent(""))
            .ReceiveJson<SynchronizationResult>()
            .ConfigureAwait(false);
    }
}
