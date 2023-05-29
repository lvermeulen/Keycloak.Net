using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Clients
{
    public class AccessTokenAuthorization
    {
        [JsonProperty("permissions")]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
