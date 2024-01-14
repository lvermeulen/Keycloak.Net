namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.ComponentModel;
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
        [JsonConverter(typeof(BooleanJsonConverter))]
        public bool? Single { get; set; }
    }
}
