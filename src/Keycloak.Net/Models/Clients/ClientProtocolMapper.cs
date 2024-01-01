namespace Keycloak.Net.Models.Clients
{
    using System.Text.Json.Serialization;

    public class ClientProtocolMapper
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }
        [JsonPropertyName("protocolMapper")]
        public string ProtocolMapper { get; set; }
        [JsonPropertyName("consentRequired")]
        public bool? ConsentRequired { get; set; }
        [JsonPropertyName("config")]
        public ClientConfig Config { get; set; }
    }
}
