namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ClientRegistration
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientRegistrationProviders Providers { get; set; }
    }
}