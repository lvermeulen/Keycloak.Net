using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class AdminEvent
    {
        [JsonProperty("authDetails")]
        public AuthDetails AuthDetails { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("operationType")]
        public string OperationType { get; set; }
        [JsonProperty("realmId")]
        public string RealmId { get; set; }
        [JsonProperty("representation")]
        public string Representation { get; set; }
        [JsonProperty("resourcePath")]
        public string ResourcePath { get; set; }
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }
        [JsonProperty("time")]
        public int? Time { get; set; }
    }
}
