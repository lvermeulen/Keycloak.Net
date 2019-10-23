using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Common.Extensions;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Users;
using Newtonsoft.Json;

namespace Keycloak.Net
{
    public class Resource
    {
        [JsonProperty("rsid")]
        public string ResourceID { get; set; }

        [JsonProperty("rsname")]
        public string ResourceName { get; set; }

        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }
    }

    public partial class KeycloakClient
    {
        /// <summary>
        /// Retrieve all resources (fine authorization mode) own by current logined user
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Resource>> GetAllResourcesOwnByCurrentUser(string realm, string clientId)
        {
            var tmps = await GetBaseUrl(realm)
                .AppendPathSegment($"/realms/{realm}/protocol/openid-connect/token")
                .PostUrlEncodedAsync(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "urn:ietf:params:oauth:grant-type:uma-ticket"),
                    new KeyValuePair<string, string>("response_mode", "permissions"),
                    new KeyValuePair<string, string>("audience", clientId)
                })
                .ReceiveJson<Resource[]>()
                .ConfigureAwait(false);

            return tmps;
        }
    }
}
