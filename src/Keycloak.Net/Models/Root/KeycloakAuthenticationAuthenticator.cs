namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Common;
    using Newtonsoft.Json;

    public class KeycloakAuthenticationAuthenticator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<ConfigProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}