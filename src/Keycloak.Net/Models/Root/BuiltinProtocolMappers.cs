namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BuiltinProtocolMappers
    {
        [JsonProperty("saml")]
        public List<Saml> Saml { get; set; }

        [JsonProperty("openid-connect")]
        public List<OpenIdConnect> OpenIdConnect { get; set; }
    }
}