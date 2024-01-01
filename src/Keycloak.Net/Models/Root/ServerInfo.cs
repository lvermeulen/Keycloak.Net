namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ServerInfo
    {
        [JsonPropertyName("systemInfo")]
        public SystemInfo SystemInfo { get; set; }

        [JsonPropertyName("memoryInfo")]
        public MemoryInfo MemoryInfo { get; set; }

        [JsonPropertyName("profileInfo")]
        public ProfileInfo ProfileInfo { get; set; }

        [JsonPropertyName("themes")]
        public Themes Themes { get; set; }

        [JsonPropertyName("socialProviders")]
        public List<Provider> SocialProviders { get; set; }

        [JsonPropertyName("identityProviders")]
        public List<Provider> IdentityProviders { get; set; }

        [JsonPropertyName("providers")]
        public ServerInfoProviders Providers { get; set; }

        [JsonPropertyName("protocolMapperTypes")]
        public ProtocolMapperTypes ProtocolMapperTypes { get; set; }

        [JsonPropertyName("builtinProtocolMappers")]
        public BuiltinProtocolMappers BuiltinProtocolMappers { get; set; }

        [JsonPropertyName("clientInstallations")]
        public ClientInstallations ClientInstallations { get; set; }

        [JsonPropertyName("componentTypes")]
        public ComponentTypes ComponentTypes { get; set; }

        [JsonPropertyName("passwordPolicies")]
        public List<PasswordPolicy> PasswordPolicies { get; set; }

        [JsonPropertyName("enums")]
        public Enums Enums { get; set; }
    }
}

