namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Port
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ExportProviders Providers { get; set; }
    }
}