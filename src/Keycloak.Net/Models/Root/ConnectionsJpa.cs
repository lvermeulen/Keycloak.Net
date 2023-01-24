namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ConnectionsJpa
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ConnectionsJpaProviders Providers { get; set; }
    }
}