namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class WellKnown
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public WellKnownProviders Providers { get; set; }
    }
}