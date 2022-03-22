using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ActionToken
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenProviders Providers { get; set; }
    }
}