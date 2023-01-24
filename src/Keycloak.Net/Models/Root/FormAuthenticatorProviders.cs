namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class FormAuthenticatorProviders
    {
        [JsonProperty("registration-page-form")]
        public HasOrder RegistrationPageForm { get; set; }
    }
}