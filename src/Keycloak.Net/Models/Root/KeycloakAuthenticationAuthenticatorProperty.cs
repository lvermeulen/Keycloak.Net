using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakAuthenticationAuthenticatorProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("type")]
        public JsonTypeLabel Type { get; set; }

        [JsonProperty("secret")]
        public bool Secret { get; set; }

        [JsonProperty("defaultValue")]
        public DefaultValue? DefaultValue { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }
}