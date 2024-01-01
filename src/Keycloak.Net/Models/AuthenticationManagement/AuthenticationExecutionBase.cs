namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public abstract class AuthenticationExecutionBase
    {
        [JsonPropertyName("authenticator")]
        public string Authenticator { get; set; }
        [JsonPropertyName("authenticatorConfig")]
        public string AuthenticatorConfig { get; set; }
        [JsonPropertyName("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }
        [JsonPropertyName("autheticatorFlow")]
        public bool? AutheticatorFlow { get; set; }
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
    }
}
