namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class FormActionProviders
    {
        [JsonPropertyName("registration-profile-action")]
        public HasOrder RegistrationProfileAction { get; set; }

        [JsonPropertyName("registration-recaptcha-action")]
        public HasOrder RegistrationRecaptchaAction { get; set; }

        [JsonPropertyName("registration-password-action")]
        public HasOrder RegistrationPasswordAction { get; set; }

        [JsonPropertyName("registration-user-creation")]
        public HasOrder RegistrationUserCreation { get; set; }
    }
}
