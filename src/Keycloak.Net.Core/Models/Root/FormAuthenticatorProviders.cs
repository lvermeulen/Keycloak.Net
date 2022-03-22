using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class FormAuthenticatorProviders
    {
        [JsonProperty("registration-page-form")]
        public HasOrder RegistrationPageForm { get; set; }
    }
}