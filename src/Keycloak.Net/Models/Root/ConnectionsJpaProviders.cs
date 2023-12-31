namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ConnectionsJpaProviders
    {
        [JsonProperty("default")]
        public Default Default { get; set; }
    }
}