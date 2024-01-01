namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class AuthorizationPersister
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public AuthorizationPersisterProviders Providers { get; set; }
    }
}
