using System.Collections.Generic;
using Keycloak.Net.Common;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Components
{
    public class ComponentTypeRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonProperty("metadata")]
        public IDictionary<string, object> Metadata { get; set; }
    }
}
