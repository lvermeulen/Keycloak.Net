namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationExecutionExport : AuthenticationExecutionBase
    {
        [JsonPropertyName("flowAlias")]
        public string FlowAlias { get; set; }
        [JsonPropertyName("userSetupAllowed")]
        public bool? UserSetupAllowed { get; set; }
    }
}
