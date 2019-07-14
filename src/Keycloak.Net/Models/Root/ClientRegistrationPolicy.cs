using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientRegistrationPolicy
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationPolicyProviders Providers { get; set; }
    }
}