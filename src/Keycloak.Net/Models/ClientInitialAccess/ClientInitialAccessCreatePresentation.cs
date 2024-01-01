namespace Keycloak.Net.Models.ClientInitialAccess
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class ClientInitialAccessCreatePresentation
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        [JsonPropertyName("expiration")]
        public int? Expiration { get; set; }
    }
}
