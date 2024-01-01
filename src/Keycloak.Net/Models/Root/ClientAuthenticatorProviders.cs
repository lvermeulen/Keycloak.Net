namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientAuthenticatorProviders
    {
        [JsonPropertyName("client-jwt")]
        public HasOrder ClientJwt { get; set; }

        [JsonPropertyName("client-secret")]
        public HasOrder ClientSecret { get; set; }

        [JsonPropertyName("client-x509")]
        public HasOrder ClientX509 { get; set; }

        [JsonPropertyName("client-secret-jwt")]
        public HasOrder ClientSecretJwt { get; set; }
    }
}
