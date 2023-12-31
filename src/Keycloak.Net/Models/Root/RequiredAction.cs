namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class RequiredAction
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public RequiredActionProviders Providers { get; set; }
    }
}