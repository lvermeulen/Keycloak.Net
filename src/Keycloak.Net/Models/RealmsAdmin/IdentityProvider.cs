using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class IdentityProvider
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("internalId")]
        public string InternalId { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("updateProfileFirstLoginMode")]
        public string UpdateProfileFirstLoginMode { get; set; }
        [JsonProperty("trustEmail")]
        public bool? TrustEmail { get; set; }
        [JsonProperty("storeToken")]
        public bool? StoreToken { get; set; }
        [JsonProperty("addReadTokenRoleOnCreate")]
        public bool? AddReadTokenRoleOnCreate { get; set; }
        [JsonProperty("authenticateByDefault")]
        public bool? AuthenticateByDefault { get; set; }
        [JsonProperty("linkOnly")]
        public bool? LinkOnly { get; set; }
        [JsonProperty("firstBrokerLoginFlowAlias")]
        public string FirstBrokerLoginFlowAlias { get; set; }
        [JsonProperty("config")]
        public Config Config { get; set; }
    }
}