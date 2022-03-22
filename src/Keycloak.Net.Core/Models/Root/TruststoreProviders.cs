using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class TruststoreProviders
    {
        [JsonProperty("file")]
        public HasOrder File { get; set; }
    }
}