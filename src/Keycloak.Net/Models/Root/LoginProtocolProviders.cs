namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class LoginProtocolProviders
    {
        [JsonProperty("saml")]
        public HasOrder Saml { get; set; }

        [JsonProperty("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}