using Newtonsoft.Json;

namespace Keycloak.Net.Models.Components
{
    public class Component
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("providerType")]
        public string ProviderType { get; set; }
        [JsonProperty("parentId")]
        public string ParentId { get; set; }
        [JsonProperty("config")]
        public Config Config { get; set; }
        [JsonProperty("subType")]
        public string SubType { get; set; }
    }
}
