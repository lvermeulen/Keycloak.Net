using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class WellKnown
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public WellKnownProviders Providers { get; set; }
    }
}