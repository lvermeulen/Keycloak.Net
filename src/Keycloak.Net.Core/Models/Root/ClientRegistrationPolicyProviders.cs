using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientRegistrationPolicyProviders
    {
        [JsonProperty("allowed-client-templates")]
        public HasOrder AllowedClientTemplates { get; set; }

        [JsonProperty("client-disabled")]
        public HasOrder ClientDisabled { get; set; }

        [JsonProperty("max-clients")]
        public HasOrder MaxClients { get; set; }

        [JsonProperty("scope")]
        public HasOrder Scope { get; set; }

        [JsonProperty("allowed-protocol-mappers")]
        public HasOrder AllowedProtocolMappers { get; set; }

        [JsonProperty("trusted-hosts")]
        public HasOrder TrustedHosts { get; set; }

        [JsonProperty("consent-required")]
        public HasOrder ConsentRequired { get; set; }
    }
}