namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Storage
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public StorageProviders Providers { get; set; }
    }
}
