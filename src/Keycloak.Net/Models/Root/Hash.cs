namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Hash
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public HashProviders Providers { get; set; }
    }
}
