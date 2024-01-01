namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class RequiredActionProviders
    {
        [JsonPropertyName("terms_and_conditions")]
        public HasOrder TermsAndConditions { get; set; }

        [JsonPropertyName("CONFIGURE_TOTP")]
        public HasOrder ConfigureTotp { get; set; }

        [JsonPropertyName("VERIFY_EMAIL")]
        public HasOrder VerifyEmail { get; set; }

        [JsonPropertyName("UPDATE_PASSWORD")]
        public HasOrder UpdatePassword { get; set; }

        [JsonPropertyName("UPDATE_PROFILE")]
        public HasOrder UpdateProfile { get; set; }
    }
}
