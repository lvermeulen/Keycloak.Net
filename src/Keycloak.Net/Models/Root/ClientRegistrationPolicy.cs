namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ClientRegistrationPolicy
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationPolicyProviders Providers { get; set; }
    }
}