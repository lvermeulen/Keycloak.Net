namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Authorization
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public AuthorizationProviders Providers { get; set; }
    }
}
