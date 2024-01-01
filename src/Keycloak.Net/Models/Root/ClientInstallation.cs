namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientInstallation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("protocol")]
        public Protocol Protocol { get; set; }

        [JsonPropertyName("downloadOnly")]
        public bool? DownloadOnly { get; set; }

        [JsonPropertyName("displayType")]
        public string DisplayType { get; set; }

        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }

        [JsonPropertyName("filename")]
        public string FileName { get; set; }

        [JsonPropertyName("mediaType")]
        public string MediaType { get; set; }
    }
}
