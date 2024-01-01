namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationFlow
    {
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        [JsonPropertyName("authenticationExecutions")]
        public IEnumerable<AuthenticationExecutionExport> AuthenticationExecutions { get; set; }
        [JsonPropertyName("builtIn")]
        public bool? BuiltIn { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        [JsonPropertyName("topLevel")]
        public bool? TopLevel { get; set; }
    }
}
