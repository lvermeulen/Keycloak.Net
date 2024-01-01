namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientDescriptionConverter
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ClientDescriptionConverterProviders Providers { get; set; }
    }
}
