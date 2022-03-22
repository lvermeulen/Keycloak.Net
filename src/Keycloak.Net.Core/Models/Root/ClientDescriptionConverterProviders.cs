using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientDescriptionConverterProviders
    {
        [JsonProperty("keycloak")]
        public HasOrder Keycloak { get; set; }

        [JsonProperty("saml2-entity-descriptor")]
        public HasOrder Saml2EntityDescriptor { get; set; }

        [JsonProperty("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}