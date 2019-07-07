using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientRegistrationProviders
    {
        [JsonProperty("default")]
        public HasOrder Default { get; set; }

        [JsonProperty("install")]
        public HasOrder Install { get; set; }

        [JsonProperty("saml2-entity-descriptor")]
        public HasOrder Saml2EntityDescriptor { get; set; }

        [JsonProperty("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}