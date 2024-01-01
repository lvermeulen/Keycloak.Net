namespace Keycloak.Net.Models.Roles
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Role
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("composite")]
        public bool? Composite { get; set; }
        [JsonPropertyName("composites")]
        public RoleComposite Composites { get; set; }
        [JsonPropertyName("clientRole")]
        public bool? ClientRole { get; set; }
        [JsonPropertyName("containerId")]
        public string ContainerId { get; set; }
        [JsonPropertyName("attributes")]
        public IDictionary<string, object> Attributes { get; set; }
    }
}

