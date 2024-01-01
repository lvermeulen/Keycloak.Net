namespace Keycloak.Net.Models.Components
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Common;
    using System.Text.Json.Serialization;

    public class ComponentType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }
        [JsonPropertyName("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonPropertyName("metadata")]
        public IDictionary<string, object> Metadata { get; set; }
    }
}

