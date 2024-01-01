namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class WellKnownProviders
    {
        [JsonPropertyName("openid-configuration")]
        public HasOrder OpenIdConfiguration { get; set; }

        [JsonPropertyName("uma2-configuration")]
        public HasOrder Uma2Configuration { get; set; }
    }
}
