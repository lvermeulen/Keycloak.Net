namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class IdentityProvider
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public IdentityProviderProviders Providers { get; set; }
    }
}