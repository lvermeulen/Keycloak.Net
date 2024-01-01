namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class BuiltinProtocolMappers
    {
        [JsonPropertyName("saml")]
        public List<Saml> Saml { get; set; }

        [JsonPropertyName("openid-connect")]
        public List<OpenIdConnect> OpenIdConnect { get; set; }
    }
}
