using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakAuthenticationFormAction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<KeycloakAuthenticationFormActionProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}