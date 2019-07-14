using Newtonsoft.Json;

namespace Keycloak.Net.Models.UserStorageProvider
{
    public class SynchronizationResult
    {
        [JsonProperty("added")]
        public int? Added { get; set; }
        [JsonProperty("failed")]
        public int? Failed { get; set; }
        [JsonProperty("ignored")]
        public bool? Ignored { get; set; }
        [JsonProperty("removed")]
        public int? Removed { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("updated")]
        public int? Updated { get; set; }
    }
}
