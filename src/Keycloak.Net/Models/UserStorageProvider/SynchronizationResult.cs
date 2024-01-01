namespace Keycloak.Net.Models.UserStorageProvider
{
    using System.Text.Json.Serialization;

    public class SynchronizationResult
    {
        [JsonPropertyName("added")]
        public int? Added { get; set; }
        [JsonPropertyName("failed")]
        public int? Failed { get; set; }
        [JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }
        [JsonPropertyName("removed")]
        public int? Removed { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("updated")]
        public int? Updated { get; set; }
    }
}

