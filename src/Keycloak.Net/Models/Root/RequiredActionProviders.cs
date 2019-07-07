using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class RequiredActionProviders
    {
        [JsonProperty("terms_and_conditions")]
        public HasOrder TermsAndConditions { get; set; }

        [JsonProperty("CONFIGURE_TOTP")]
        public HasOrder ConfigureTotp { get; set; }

        [JsonProperty("VERIFY_EMAIL")]
        public HasOrder VerifyEmail { get; set; }

        [JsonProperty("UPDATE_PASSWORD")]
        public HasOrder UpdatePassword { get; set; }

        [JsonProperty("UPDATE_PROFILE")]
        public HasOrder UpdateProfile { get; set; }
    }
}