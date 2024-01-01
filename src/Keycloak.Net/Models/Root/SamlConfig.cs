namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class SamlConfig
    {
        [JsonPropertyName("attribute.nameformat")]
        public string AttributeNameformat { get; set; }

        [JsonPropertyName("user.attribute")]
        public string UserAttribute { get; set; }

        [JsonPropertyName("friendly.name")]
        public string FriendlyName { get; set; }

        [JsonPropertyName("attribute.name")]
        public string AttributeName { get; set; }

        [JsonPropertyName("single")]
        public bool? Single { get; set; }
    }
}
