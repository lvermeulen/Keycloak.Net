using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.AuthenticationManagement
{
    public class AuthenticationFlow
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("authenticationExecutions")]
        public IEnumerable<AuthenticationExecutionExport> AuthenticationExecutions { get; set; }
        [JsonProperty("builtIn")]
        public bool? BuiltIn { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("topLevel")]
        public bool? TopLevel { get; set; }
    }
}
