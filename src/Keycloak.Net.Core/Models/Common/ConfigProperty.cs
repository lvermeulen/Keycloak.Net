using System.Collections.Generic;
using Keycloak.Net.Models.Root;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Common
{
    public class ConfigProperty
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
        public bool? Secret { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }
}
