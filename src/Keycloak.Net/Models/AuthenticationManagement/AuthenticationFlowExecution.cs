namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationFlowExecution
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonPropertyName("requirementChoices")]
        public IEnumerable<string> RequirementChoices { get; set; }
        [JsonPropertyName("configurable")]
        public bool? Configurable { get; set; }
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        [JsonPropertyName("level")]
        public int? Level { get; set; }
        [JsonPropertyName("index")]
        public int? Index { get; set; }
        [JsonPropertyName("authenticationFlow")]
        public bool? AuthenticationFlow { get; set; }
        [JsonPropertyName("flowId")]
        public string FlowId { get; set; }
    }
}
