namespace Keycloak.Net.Models.Common
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Roles;
    using System.Text.Json.Serialization;

    public class Mapping
    {
        [JsonPropertyName("clientMappings")]
        public IDictionary<string, ClientRoleMapping> ClientMappings { get; set; }
        [JsonPropertyName("realmMappings")]
        public IEnumerable<Role> RealmMappings { get; set; }
    }
}

