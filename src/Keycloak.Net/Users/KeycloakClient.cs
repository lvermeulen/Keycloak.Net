using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Common;
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

        public async Task<string> GetUserConsentsAsync(string realm, string userId)
        {
            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/{userId}/consents")
                .GetStringAsync()
                .ConfigureAwait(false);
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
            return Convert.ToInt32(Converter.GetFirstPropertyValue(result));
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
    }
}
