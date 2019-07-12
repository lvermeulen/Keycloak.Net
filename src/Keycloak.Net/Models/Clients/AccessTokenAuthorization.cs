using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class AccessTokenAuthorization
    {
        [JsonProperty("permissions")]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
