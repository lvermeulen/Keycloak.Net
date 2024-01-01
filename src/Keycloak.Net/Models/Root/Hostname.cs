namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Hostname
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public HostnameProviders Providers { get; set; }
    }
}
