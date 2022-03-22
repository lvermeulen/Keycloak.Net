using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientAuthenticatorProviders
    {
        [JsonProperty("client-jwt")]
        public HasOrder ClientJwt { get; set; }

        [JsonProperty("client-secret")]
        public HasOrder ClientSecret { get; set; }

        [JsonProperty("client-x509")]
        public HasOrder ClientX509 { get; set; }

        [JsonProperty("client-secret-jwt")]
        public HasOrder ClientSecretJwt { get; set; }
    }
}