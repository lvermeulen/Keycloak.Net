using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class AuthorizationCache
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HasDefault Providers { get; set; }
    }
}