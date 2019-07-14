using Newtonsoft.Json;

namespace Keycloak.Net.Models.Key
{
    public class Key
    {
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("providerPriority")]
        public int? ProviderPriority { get; set; }
        [JsonProperty("kid")]
        public string Kid { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }
        [JsonProperty("publicKey")]
        public string PublicKey { get; set; }
        [JsonProperty("certificate")]
        public string Certificate { get; set; }
    }
}