using Keycloak.Net.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.AuthenticationManagement
{
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
