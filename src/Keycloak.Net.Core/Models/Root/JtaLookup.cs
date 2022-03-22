using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class JtaLookup
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public JtaLookupProviders Providers { get; set; }
    }
}