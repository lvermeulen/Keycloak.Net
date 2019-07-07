using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class AuthorizationProviders
    {
        [JsonProperty("authorization")]
        public HasOrder Authorization { get; set; }
    }
}