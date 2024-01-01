namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class BruteForceProtectorProviders
    {
        [JsonPropertyName("default-brute-force-detector")]
        public HasOrder DefaultBruteForceDetector { get; set; }
    }
}
