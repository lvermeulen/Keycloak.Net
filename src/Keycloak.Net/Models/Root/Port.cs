namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Port
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ExportProviders Providers { get; set; }
    }
}
