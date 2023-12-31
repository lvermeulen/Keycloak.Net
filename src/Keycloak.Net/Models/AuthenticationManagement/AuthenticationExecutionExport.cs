namespace Keycloak.Net.Models.AuthenticationManagement
{
    using Newtonsoft.Json;

    public class AuthenticationExecutionExport : AuthenticationExecutionBase
    {
        [JsonProperty("flowAlias")]
        public string FlowAlias { get; set; }
        [JsonProperty("userSetupAllowed")]
        public bool? UserSetupAllowed { get; set; }
    }
}
