namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ActionTokenHandler
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenHandlerProviders Providers { get; set; }
    }
}