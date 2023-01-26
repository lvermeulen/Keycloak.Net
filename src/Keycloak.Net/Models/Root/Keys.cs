namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Keys
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public KeysProviders Providers { get; set; }
    }
}