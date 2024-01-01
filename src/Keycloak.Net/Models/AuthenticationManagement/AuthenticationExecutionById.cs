namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationExecutionById
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("authenticator")]
        public string Authenticator { get; set; }
        [JsonPropertyName("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        [JsonPropertyName("parentFlow")]
        public string ParentFlow { get; set; }
        [JsonPropertyName("optional")]
        public bool? Optional { get; set; }
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        [JsonPropertyName("required")]
        public bool? Required { get; set; }
        [JsonPropertyName("alternative")]
        public bool? Alternative { get; set; }
        [JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }
    }
}
