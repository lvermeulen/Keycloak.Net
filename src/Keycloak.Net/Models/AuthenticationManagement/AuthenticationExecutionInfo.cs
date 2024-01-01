namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationExecutionInfo
    {
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        [JsonPropertyName("authenticationConfig")]
        public string AuthenticationConfig { get; set; }
        [JsonPropertyName("authenticationFlow")]
        public bool? AuthenticationFlow { get; set; }
        [JsonPropertyName("configurable")]
        public bool? Configurable { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonPropertyName("flowId")]
        public string FlowId { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("index")]
        public int? Index { get; set; }
        [JsonPropertyName("level")]
        public int? Level { get; set; }
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
        [JsonPropertyName("requirementChoices")]
        public IEnumerable<string> RequirementChoices { get; set; }
    }
}
