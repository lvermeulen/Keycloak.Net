using System.Collections.Generic;
using Keycloak.Net.Models.Roles;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class Roles
    {
        [JsonProperty("client")]
        public IDictionary<string, object> Client { get; set; }
        [JsonProperty("realm")]
        public IEnumerable<Role> Realm { get; set; }
    }
}
