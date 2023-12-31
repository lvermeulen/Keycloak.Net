namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class CredentialProviders
    {
        [JsonProperty("keycloak-otp")]
        public HasOrder KeycloakOtp { get; set; }

        [JsonProperty("keycloak-password")]
        public HasOrder KeycloakPassword { get; set; }
    }
}