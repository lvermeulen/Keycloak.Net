namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class CredentialProviders
    {
        [JsonPropertyName("keycloak-otp")]
        public HasOrder KeycloakOtp { get; set; }

        [JsonPropertyName("keycloak-password")]
        public HasOrder KeycloakPassword { get; set; }
    }
}
