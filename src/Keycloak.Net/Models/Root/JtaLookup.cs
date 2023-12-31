namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class JtaLookup
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public JtaLookupProviders Providers { get; set; }
    }
}