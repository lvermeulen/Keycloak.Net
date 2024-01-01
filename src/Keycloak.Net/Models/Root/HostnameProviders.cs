namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class HostnameProviders
    {
        [JsonPropertyName("request")]
        public HasOrder Request { get; set; }
    }
}
