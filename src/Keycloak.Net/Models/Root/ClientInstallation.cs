using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientInstallation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protocol")]
        public Protocol Protocol { get; set; }

        [JsonProperty("downloadOnly")]
        public bool? DownloadOnly { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }
    }
}