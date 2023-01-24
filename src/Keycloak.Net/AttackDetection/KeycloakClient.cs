namespace Keycloak.Net
{
    using System.Threading.Tasks;
    using Flurl.Http;
    using Keycloak.Net.Models.AttackDetection;

    public partial class KeycloakClient
    {
        public async Task<bool> ClearUserLoginFailuresAsync(string realm)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> ClearUserLoginFailuresAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users/{userId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<UserNameStatus> GetUserNameStatusInBruteForceDetectionAsync(string realm, string userId)
        {

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users/{userId}")
                .GetJsonAsync<UserNameStatus>()
                .ConfigureAwait(false);
        }
    }
}
