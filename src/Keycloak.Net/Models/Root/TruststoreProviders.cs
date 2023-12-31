namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class TruststoreProviders
    {
        [JsonProperty("file")]
        public HasOrder File { get; set; }
    }
}