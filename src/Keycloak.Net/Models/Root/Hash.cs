namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Hash
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HashProviders Providers { get; set; }
    }
}