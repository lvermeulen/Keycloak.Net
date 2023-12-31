namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class BruteForceProtectorProviders
    {
        [JsonProperty("default-brute-force-detector")]
        public HasOrder DefaultBruteForceDetector { get; set; }
    }
}