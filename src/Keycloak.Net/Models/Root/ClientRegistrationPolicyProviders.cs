namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientRegistrationPolicyProviders
    {
        [JsonPropertyName("allowed-client-templates")]
        public HasOrder AllowedClientTemplates { get; set; }

        [JsonPropertyName("client-disabled")]
        public HasOrder ClientDisabled { get; set; }

        [JsonPropertyName("max-clients")]
        public HasOrder MaxClients { get; set; }

        [JsonPropertyName("scope")]
        public HasOrder Scope { get; set; }

        [JsonPropertyName("allowed-protocol-mappers")]
        public HasOrder AllowedProtocolMappers { get; set; }

        [JsonPropertyName("trusted-hosts")]
        public HasOrder TrustedHosts { get; set; }

        [JsonPropertyName("consent-required")]
        public HasOrder ConsentRequired { get; set; }
    }
}
