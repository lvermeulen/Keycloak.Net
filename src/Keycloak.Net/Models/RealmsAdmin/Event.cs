using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class Event
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("details")]
        public IDictionary<string, object> Details { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty("realmId")]
        public string RealmId { get; set; }
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
