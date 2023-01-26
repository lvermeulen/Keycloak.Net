namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class IdentityProviderProviders
    {
        [JsonProperty("saml")]
        public HasOrder Saml { get; set; }

        [JsonProperty("oidc")]
        public HasOrder Oidc { get; set; }

        [JsonProperty("keycloak-oidc")]
        public HasOrder KeycloakOidc { get; set; }
    }
}