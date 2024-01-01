namespace Keycloak.Net.Models.IdentityProviders
{
    using System.Text.Json.Serialization;

    public class IdentityProviderInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}

