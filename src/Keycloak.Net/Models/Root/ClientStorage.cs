namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ClientStorage
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public MetadataClass Providers { get; set; }
    }
}