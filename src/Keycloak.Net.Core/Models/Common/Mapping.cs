using System.Collections.Generic;
using Keycloak.Net.Models.Roles;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Common
{
    public class Mapping
    {
        [JsonProperty("clientMappings")]
        public IDictionary<string, ClientRoleMapping> ClientMappings { get; set; }
        [JsonProperty("realmMappings")]
        public IEnumerable<Role> RealmMappings { get; set; }
    }
}
