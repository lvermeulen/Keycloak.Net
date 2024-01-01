namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ConnectionsJpaProviders
    {
        [JsonPropertyName("default")]
        public Default Default { get; set; }
    }
}
