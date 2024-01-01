namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Event
    {
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
        [JsonPropertyName("details")]
        public IDictionary<string, object> Details { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
        [JsonPropertyName("realmId")]
        public string RealmId { get; set; }
        [JsonPropertyName("sessionId")]
        public string SessionId { get; set; }
        [JsonPropertyName("time")]
        public long Time { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}

