namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Saml
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("protocol")]
        public Protocol Protocol { get; set; }

        [JsonPropertyName("protocolMapper")]
        public string ProtocolMapper { get; set; }

        [JsonPropertyName("consentRequired")]
        public bool? ConsentRequired { get; set; }

        [JsonPropertyName("config")]
        public SamlConfig Config { get; set; }
    }
}
