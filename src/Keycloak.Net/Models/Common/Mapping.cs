namespace Keycloak.Net.Models.Common
{
    using System.Collections.Generic;
    using Roles;
    using Newtonsoft.Json;

    public class Mapping
    {
        [JsonProperty("clientMappings")]
        public IDictionary<string, ClientRoleMapping> ClientMappings { get; set; }
        [JsonProperty("realmMappings")]
        public IEnumerable<Role> RealmMappings { get; set; }
    }
}
