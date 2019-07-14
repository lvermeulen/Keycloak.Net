using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientRegistration
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationProviders Providers { get; set; }
    }
}