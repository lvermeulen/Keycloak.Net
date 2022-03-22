using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ServerInfo
    {
        [JsonProperty("systemInfo")]
        public SystemInfo SystemInfo { get; set; }

        [JsonProperty("memoryInfo")]
        public MemoryInfo MemoryInfo { get; set; }

        [JsonProperty("profileInfo")]
        public ProfileInfo ProfileInfo { get; set; }

        [JsonProperty("themes")]
        public Themes Themes { get; set; }

        [JsonProperty("socialProviders")]
        public List<Provider> SocialProviders { get; set; }

        [JsonProperty("identityProviders")]
        public List<Provider> IdentityProviders { get; set; }

        [JsonProperty("providers")]
        public ServerInfoProviders Providers { get; set; }

        [JsonProperty("protocolMapperTypes")]
        public ProtocolMapperTypes ProtocolMapperTypes { get; set; }

        [JsonProperty("builtinProtocolMappers")]
        public BuiltinProtocolMappers BuiltinProtocolMappers { get; set; }

        [JsonProperty("clientInstallations")]
        public ClientInstallations ClientInstallations { get; set; }

        [JsonProperty("componentTypes")]
        public ComponentTypes ComponentTypes { get; set; }

        [JsonProperty("passwordPolicies")]
        public List<PasswordPolicy> PasswordPolicies { get; set; }

        [JsonProperty("enums")]
        public Enums Enums { get; set; }
    }
}
