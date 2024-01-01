namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Keys
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public KeysProviders Providers { get; set; }
    }
}
