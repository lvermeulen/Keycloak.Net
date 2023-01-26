namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Truststore
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public TruststoreProviders Providers { get; set; }
    }
}