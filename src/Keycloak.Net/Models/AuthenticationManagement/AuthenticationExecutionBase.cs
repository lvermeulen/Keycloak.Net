using Newtonsoft.Json;

namespace Keycloak.Net.Models.AuthenticationManagement
{
    public abstract class AuthenticationExecutionBase
    {
        [JsonProperty("authenticator")]
        public string Authenticator { get; set; }
        [JsonProperty("authenticatorConfig")]
        public string AuthenticatorConfig { get; set; }
        [JsonProperty("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }
        [JsonProperty("autheticatorFlow")]
        public bool? AutheticatorFlow { get; set; }
        [JsonProperty("priority")]
        public int? Priority { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
    }
}
