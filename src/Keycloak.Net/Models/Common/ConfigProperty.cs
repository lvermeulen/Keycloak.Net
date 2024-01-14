namespace Keycloak.Net.Models.Common
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Root;
    using System.Text.Json.Serialization;
    using Keycloak.Net.Common.Converters;

    public class ConfigProperty
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }

        [JsonPropertyName("type")]
        public JsonTypeLabel Type { get; set; }

        [JsonPropertyName("secret")]
        public bool? Secret { get; set; }

        [JsonPropertyName("defaultValue")]
        [JsonConverter(typeof(AlwaysStringJsonConverter))]
        public string DefaultValue { get; set; }

        [JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }
}

