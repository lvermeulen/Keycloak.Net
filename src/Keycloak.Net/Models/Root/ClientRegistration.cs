namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientRegistration
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ClientRegistrationProviders Providers { get; set; }
    }
}
