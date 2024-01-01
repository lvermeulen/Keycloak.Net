namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class WellKnown
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public WellKnownProviders Providers { get; set; }
    }
}
