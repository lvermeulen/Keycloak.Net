using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientStorage
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public MetadataClass Providers { get; set; }
    }
}