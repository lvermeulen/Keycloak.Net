using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakAuthenticationAuthenticator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<KeycloakAuthenticationAuthenticatorProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}