namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Policy
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public PolicyProviders Providers { get; set; }
    }
}