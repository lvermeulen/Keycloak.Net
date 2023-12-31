namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class EmailTemplateClass
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public AccountProviders Providers { get; set; }
    }
}