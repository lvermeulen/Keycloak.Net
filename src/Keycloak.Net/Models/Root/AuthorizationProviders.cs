namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class AuthorizationProviders
    {
        [JsonPropertyName("authorization")]
        public HasOrder Authorization { get; set; }
    }
}
