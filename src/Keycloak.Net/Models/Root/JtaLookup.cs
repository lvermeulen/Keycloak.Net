namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class JtaLookup
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public JtaLookupProviders Providers { get; set; }
    }
}
