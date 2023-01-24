namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ClientAuthenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientAuthenticatorProviders Providers { get; set; }
    }
}