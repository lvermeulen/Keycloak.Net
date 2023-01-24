namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Hostname
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HostnameProviders Providers { get; set; }
    }
}