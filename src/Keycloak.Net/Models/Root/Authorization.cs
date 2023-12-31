namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Authorization
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public AuthorizationProviders Providers { get; set; }
    }
}