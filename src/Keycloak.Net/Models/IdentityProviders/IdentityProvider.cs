namespace Keycloak.Net.Models.IdentityProviders
{
    using System.Text.Json.Serialization;

    public class IdentityProvider
    {
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        [JsonPropertyName("internalId")]
        public string InternalId { get; set; }
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        [JsonPropertyName("updateProfileFirstLoginMode")]
        public string UpdateProfileFirstLoginMode { get; set; }
        [JsonPropertyName("trustEmail")]
        public bool? TrustEmail { get; set; }
        [JsonPropertyName("storeToken")]
        public bool? StoreToken { get; set; }
        [JsonPropertyName("addReadTokenRoleOnCreate")]
        public bool? AddReadTokenRoleOnCreate { get; set; }
        [JsonPropertyName("authenticateByDefault")]
        public bool? AuthenticateByDefault { get; set; }
        [JsonPropertyName("linkOnly")]
        public bool? LinkOnly { get; set; }
        [JsonPropertyName("firstBrokerLoginFlowAlias")]
        public string FirstBrokerLoginFlowAlias { get; set; }
        [JsonPropertyName("config")]
        public Config Config { get; set; }
    }
}

