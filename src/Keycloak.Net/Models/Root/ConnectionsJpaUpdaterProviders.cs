using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ConnectionsJpaUpdaterProviders
    {
        [JsonProperty("liquibase")]
        public HasOrder Liquibase { get; set; }
    }
}