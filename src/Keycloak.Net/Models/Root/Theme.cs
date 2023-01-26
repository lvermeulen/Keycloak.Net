namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Theme
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ThemeProviders Providers { get; set; }
    }
}