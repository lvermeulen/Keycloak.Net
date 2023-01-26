namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Storage
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public StorageProviders Providers { get; set; }
    }
}