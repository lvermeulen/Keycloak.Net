using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ActionTokenHandler
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenHandlerProviders Providers { get; set; }
    }
}