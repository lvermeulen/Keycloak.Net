namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ConnectionsJpaUpdaterProviders
    {
        [JsonPropertyName("liquibase")]
        public HasOrder Liquibase { get; set; }
    }
}
