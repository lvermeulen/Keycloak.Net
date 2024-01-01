namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class LoginProtocolProviders
    {
        [JsonPropertyName("saml")]
        public HasOrder Saml { get; set; }

        [JsonPropertyName("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}
