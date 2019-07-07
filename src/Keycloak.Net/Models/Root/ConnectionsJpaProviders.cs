using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ConnectionsJpaProviders
    {
        [JsonProperty("default")]
        public Default Default { get; set; }
    }
}