namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ThemeProviders
    {
        [JsonProperty("folder")]
        public HasOrder Folder { get; set; }

        [JsonProperty("module")]
        public HasOrder Module { get; set; }

        [JsonProperty("jar")]
        public HasOrder Jar { get; set; }

        [JsonProperty("extending")]
        public HasOrder Extending { get; set; }
    }
}