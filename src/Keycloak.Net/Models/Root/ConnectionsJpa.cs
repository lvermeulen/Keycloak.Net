namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ConnectionsJpa
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ConnectionsJpaProviders Providers { get; set; }
    }
}
