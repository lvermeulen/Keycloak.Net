using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Policy
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public PolicyProviders Providers { get; set; }
    }
}