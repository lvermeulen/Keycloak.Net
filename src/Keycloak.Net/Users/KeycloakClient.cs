using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Users;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateUserAsync(string realm, User user)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users")
                .PostJsonAsync(user)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<User>> GetUsersAsync(string realm, bool? briefRepresentation = null, string email = null, int? first = null,
            string firstName = null, string lastName = null, int? max = null, string search = null, string username = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(briefRepresentation)] = briefRepresentation,
                [nameof(email)] = email,
                [nameof(first)] = first,
                [nameof(firstName)] = firstName,
                [nameof(lastName)] = lastName,
                [nameof(max)] = max,
                [nameof(search)] = search,
                [nameof(username)] = username
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<User>>()
                .ConfigureAwait(false);
        }

        public async Task<int> GetUsersCountAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/count")
            .GetJsonAsync<int>()
            .ConfigureAwait(false);

        public async Task<User> GetUserAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}")
            .GetJsonAsync<User>()
            .ConfigureAwait(false);

        public async Task<bool> UpdateUserAsync(string realm, string userId, User user)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}")
                .PutJsonAsync(user)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        [Obsolete("Not working yet", error: true)]
        public async Task<string> GetUserConsentsAsync(string realm, string userId)
        {
            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/consents")
                .GetStringAsync()
                .ConfigureAwait(false);
        }

        public async Task<bool> RevokeUserConsentAndOfflineTokensAsync(string realm, string userId, string clientId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/consents/{clientId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DisableUserCredentialsAsync(string realm, string userId, IEnumerable<string> credentialTypes)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/disable-credential-types")
                .PutJsonAsync(credentialTypes)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SendUserUpdateAccountEmailAsync(string realm, string userId, IEnumerable<string> requiredActions, string clientId = null, int? lifespan = null, string redirectUri = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                ["client_id"] = clientId,
                [nameof(lifespan)] = lifespan,
                ["redirect_uri"] = redirectUri
            };

            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/execute-actions-email")
                .SetQueryParams(queryParams)
                .PutJsonAsync(requiredActions)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<FederatedIdentity>> GetUserSocialLoginsAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/federated-identity")
            .GetJsonAsync<IEnumerable<FederatedIdentity>>()
            .ConfigureAwait(false);

        public async Task<bool> AddUserSocialLoginProviderAsync(string realm, string userId, string provider, FederatedIdentity federatedIdentity)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/federated-identity/{provider}")
                .PostJsonAsync(federatedIdentity)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveUserSocialLoginProviderAsync(string realm, string userId, string provider)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/federated-identity/{provider}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Group>> GetUserGroupsAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/groups")
            .GetJsonAsync<IEnumerable<Group>>()
            .ConfigureAwait(false);

        public async Task<int> GetUserGroupsCountAsync(string realm, string userId)
        {
            var result = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/groups/count")
                .GetJsonAsync()
                .ConfigureAwait(false);
            return Convert.ToInt32(DynamicExtensions.GetFirstPropertyValue(result));
        }

        public async Task<bool> UpdateUserGroupAsync(string realm, string userId, string groupId, Group group)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/groups/{groupId}")
                .PutJsonAsync(group)
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserGroupAsync(string realm, string userId, string groupId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/groups/{groupId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IDictionary<string, object>> ImpersonateUserAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/impersonation")
                .PostAsync(new StringContent(""))
                .ReceiveJson()
                .ConfigureAwait(false);
            return DynamicExtensions.DynamicToDictionary(response);
        }

        public async Task<bool> RemoveUserSessionsAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/logout")
                .PostAsync(new StringContent(""))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        [Obsolete("Not working yet", error: true)]
        public async Task<IEnumerable<UserSession>> GetUserOfflineSessionsAsync(string realm, string userId, string clientId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/offline-sessions/{clientId}")
            .GetJsonAsync<IEnumerable<UserSession>>()
            .ConfigureAwait(false);

        public async Task<bool> RemoveUserTotpAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/remove-totp")
                .PutAsync(new StringContent(""))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ResetUserPasswordAsync(string realm, string userId, string password)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/reset-password")
                .PutJsonAsync(new { password })
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> VerifyUserEmailAddressAsync(string realm, string userId, string clientId = null, string redirectUri = null)
        {
            var queryParams = new Dictionary<string, object>
            {
                ["client_id"] = clientId,
                ["redirect_uri"] = redirectUri
            };

            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/send-verify-email")
                .SetQueryParams(queryParams)
                .PutJsonAsync(new StringContent(""))
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<UserSession>> GetUserSessionsAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/sessions")
            .GetJsonAsync<IEnumerable<UserSession>>()
            .ConfigureAwait(false);
    }
}
