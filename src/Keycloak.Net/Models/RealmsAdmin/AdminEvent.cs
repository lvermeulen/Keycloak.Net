namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Text.Json.Serialization;

    public class AdminEvent
    {
        [JsonPropertyName("authDetails")]
        public AuthDetails AuthDetails { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("operationType")]
        public string OperationType { get; set; }
        [JsonPropertyName("realmId")]
        public string RealmId { get; set; }
        [JsonPropertyName("representation")]
        public string Representation { get; set; }
        [JsonPropertyName("resourcePath")]
        public string ResourcePath { get; set; }
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }
        [JsonPropertyName("time")]
        public int? Time { get; set; }
    }
}

