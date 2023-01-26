namespace Keycloak.Net.Models.AuthenticationManagement
{
    using Newtonsoft.Json;

    public class AuthenticationExecution : AuthenticationExecutionBase
    {
        [JsonProperty("flowId")]
        public string FlowId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("parentFlow")]
        public string ParentFlow { get; set; }
    }
}