namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class FormAuthenticator
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public FormAuthenticatorProviders Providers { get; set; }
    }
}
