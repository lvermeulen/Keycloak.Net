namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class HashProviders
    {
        [JsonProperty("SHA-384")]
        public HasOrder Sha384 { get; set; }

        [JsonProperty("SHA-256")]
        public HasOrder Sha256 { get; set; }

        [JsonProperty("SHA-512")]
        public HasOrder Sha512 { get; set; }
    }
}