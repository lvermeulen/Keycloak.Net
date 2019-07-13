using System.Collections.Generic;
using Keycloak.Net.Models.Roles;
using Newtonsoft.Json;

namespace Keycloak.Net.Common
{
    public class Mapping
    {
        [JsonProperty("clientMappings")]
        public IDictionary<string, object> ClientMappings { get; set; }
        [JsonProperty("realmMappings")]
        public IEnumerable<Role> RealmMappings { get; set; }
    }
}
