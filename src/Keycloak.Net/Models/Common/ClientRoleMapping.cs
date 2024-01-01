namespace Keycloak.Net.Models.Common
{
    using Keycloak.Net.Models.Roles;
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    public class ClientRoleMapping
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("client")]
        public string Client { get; set; }
        [JsonPropertyName("mappings")]
        public List<Role> Mappings { get; set; }
    }
}

