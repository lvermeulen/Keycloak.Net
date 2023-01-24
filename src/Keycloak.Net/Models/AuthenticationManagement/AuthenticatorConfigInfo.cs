namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using Common;
    using Newtonsoft.Json;

    public class AuthenticatorConfigInfo
    {
        [JsonProperty("helpText")]
        public string HelpText { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("properties")]
        public IEnumerable<ConfigProperty> Properties { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
    }
}
