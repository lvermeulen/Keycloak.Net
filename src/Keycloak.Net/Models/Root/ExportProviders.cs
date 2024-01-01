namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ExportProviders
    {
        [JsonPropertyName("singleFile")]
        public HasOrder SingleFile { get; set; }

        [JsonPropertyName("dir")]
        public HasOrder Dir { get; set; }
    }
}
