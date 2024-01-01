namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ConnectionsJpaUpdater
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ConnectionsJpaUpdaterProviders Providers { get; set; }
    }
}
