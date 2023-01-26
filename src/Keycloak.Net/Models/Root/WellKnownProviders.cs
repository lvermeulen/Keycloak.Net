namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class WellKnownProviders
    {
        [JsonProperty("openid-configuration")]
        public HasOrder OpenIdConfiguration { get; set; }

        [JsonProperty("uma2-configuration")]
        public HasOrder Uma2Configuration { get; set; }
    }
}