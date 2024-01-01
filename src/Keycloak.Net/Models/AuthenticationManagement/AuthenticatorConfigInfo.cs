namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Common;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticatorConfigInfo
    {
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
    }
}
