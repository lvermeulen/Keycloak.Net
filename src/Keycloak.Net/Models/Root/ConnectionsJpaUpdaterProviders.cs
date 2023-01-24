namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ConnectionsJpaUpdaterProviders
    {
        [JsonProperty("liquibase")]
        public HasOrder Liquibase { get; set; }
    }
}