using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class FormActionProviders
    {
        [JsonProperty("registration-profile-action")]
        public HasOrder RegistrationProfileAction { get; set; }

        [JsonProperty("registration-recaptcha-action")]
        public HasOrder RegistrationRecaptchaAction { get; set; }

        [JsonProperty("registration-password-action")]
        public HasOrder RegistrationPasswordAction { get; set; }

        [JsonProperty("registration-user-creation")]
        public HasOrder RegistrationUserCreation { get; set; }
    }
}