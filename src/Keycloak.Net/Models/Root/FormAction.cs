namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class FormAction
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public FormActionProviders Providers { get; set; }
    }
}