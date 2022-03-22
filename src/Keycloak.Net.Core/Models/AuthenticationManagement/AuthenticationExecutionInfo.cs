using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.AuthenticationManagement
{
    public class AuthenticationExecutionInfo
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("authenticationConfig")]
        public string AuthenticationConfig { get; set; }
        [JsonProperty("authenticationFlow")]
        public bool? AuthenticationFlow { get; set; }
        [JsonProperty("configurable")]
        public bool? Configurable { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("flowId")]
        public string FlowId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("index")]
        public int? Index { get; set; }
        [JsonProperty("level")]
        public int? Level { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("requirementChoices")]
        public IEnumerable<string> RequirementChoices { get; set; }
    }
}
