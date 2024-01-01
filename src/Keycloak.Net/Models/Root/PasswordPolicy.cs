namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class PasswordPolicy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("configType")]
        public ConfigType? ConfigType { get; set; }

        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonPropertyName("multipleSupported")]
        public bool? MultipleSupported { get; set; }
    }
}
