namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ConnectionsJpaUpdater
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ConnectionsJpaUpdaterProviders Providers { get; set; }
    }
}