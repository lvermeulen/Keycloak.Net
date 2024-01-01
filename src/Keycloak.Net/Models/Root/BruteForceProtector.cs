namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class BruteForceProtector
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public BruteForceProtectorProviders Providers { get; set; }
    }
}
