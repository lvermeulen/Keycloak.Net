namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class TruststoreProviders
    {
        [JsonPropertyName("file")]
        public HasOrder File { get; set; }
    }
}
