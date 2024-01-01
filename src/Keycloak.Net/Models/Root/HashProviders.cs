namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class HashProviders
    {
        [JsonPropertyName("SHA-384")]
        public HasOrder Sha384 { get; set; }

        [JsonPropertyName("SHA-256")]
        public HasOrder Sha256 { get; set; }

        [JsonPropertyName("SHA-512")]
        public HasOrder Sha512 { get; set; }
    }
}
