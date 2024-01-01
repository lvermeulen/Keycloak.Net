namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Truststore
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public TruststoreProviders Providers { get; set; }
    }
}
