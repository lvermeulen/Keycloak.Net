using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Users;
using Newtonsoft.Json;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<IEnumerable<User>> GetUsersAsync(string realm)
        {
            string stringResult = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users")
                .GetStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<User>>(stringResult);
            return result;
        }

        public async Task<int> GetUsersCountAsync(string realm)
        {
            string stringResult = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/users/count")
                .GetStringAsync();

            int result = JsonConvert.DeserializeObject<int>(stringResult);
            return result;
        }
    }
}
