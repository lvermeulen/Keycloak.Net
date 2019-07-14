using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Hash
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HashProviders Providers { get; set; }
    }
}