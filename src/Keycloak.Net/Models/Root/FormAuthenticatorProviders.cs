namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class FormAuthenticatorProviders
    {
        [JsonPropertyName("registration-page-form")]
        public HasOrder RegistrationPageForm { get; set; }
    }
}
