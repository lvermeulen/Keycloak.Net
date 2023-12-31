namespace Keycloak.Net.Models.ClientInitialAccess
{
    using Newtonsoft.Json;

    public class ClientInitialAccessCreatePresentation
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
        [JsonProperty("expiration")]
        public int? Expiration { get; set; }
    }
}
