namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientAuthenticator
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ClientAuthenticatorProviders Providers { get; set; }
    }
}
