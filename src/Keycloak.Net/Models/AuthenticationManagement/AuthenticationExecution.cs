namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticationExecution : AuthenticationExecutionBase
    {
        [JsonPropertyName("flowId")]
        public string FlowId { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("parentFlow")]
        public string ParentFlow { get; set; }
    }
}