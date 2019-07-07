using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class BuiltinProtocolMappers
    {
        [JsonProperty("saml")]
        public List<Saml> Saml { get; set; }

        [JsonProperty("openid-connect")]
        public List<OpenIdConnect> OpenIdConnect { get; set; }
    }
}