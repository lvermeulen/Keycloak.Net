namespace Keycloak.Net.Models.Key
{
    using System.Text.Json.Serialization;

    public class Key
    {
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        [JsonPropertyName("providerPriority")]
        public int? ProviderPriority { get; set; }
        [JsonPropertyName("kid")]
        public string Kid { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }
        [JsonPropertyName("publicKey")]
        public string PublicKey { get; set; }
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
    }
}
