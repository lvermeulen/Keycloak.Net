namespace Keycloak.Net.Models.AuthorizationScopes
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthorizationScope
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
