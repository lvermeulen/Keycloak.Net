using Newtonsoft.Json;

namespace Keycloak.Net.Models.ClientInitialAccess
{
    public class ClientInitialAccessPresentation : ClientInitialAccessCreatePresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("remainingCount")]
        public int? RemainingCount { get; set; }
        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
