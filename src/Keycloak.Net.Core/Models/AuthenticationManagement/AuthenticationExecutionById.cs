using Newtonsoft.Json;

namespace Keycloak.Net.Models.AuthenticationManagement
{
    public class AuthenticationExecutionById
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("authenticator")]
        public string Authenticator { get; set; }
        [JsonProperty("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("priority")]
        public int? Priority { get; set; }
        [JsonProperty("parentFlow")]
        public string ParentFlow { get; set; }
        [JsonProperty("optional")]
        public bool? Optional { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("required")]
        public bool? Required { get; set; }
        [JsonProperty("alternative")]
        public bool? Alternative { get; set; }
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
    }
}
