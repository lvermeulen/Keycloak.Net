namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class Client
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("baseUrl")]
        public string BaseUrl { get; set; }
        [JsonPropertyName("surrogateAuthRequired")]
        public bool? SurrogateAuthRequired { get; set; }
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        [JsonPropertyName("clientAuthenticatorType")]
        public string ClientAuthenticatorType { get; set; }
        [JsonPropertyName("redirectUris")]
        public IEnumerable<string> RedirectUris { get; set; }
        [JsonPropertyName("webOrigins")]
        public IEnumerable<object> WebOrigins { get; set; }
        [JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }
        [JsonPropertyName("bearerOnly")]
        public bool? BearerOnly { get; set; }
        [JsonPropertyName("consentRequired")]
        public bool? ConsentRequired { get; set; }
        [JsonPropertyName("standardFlowEnabled")]
        public bool? StandardFlowEnabled { get; set; }
        [JsonPropertyName("implicitFlowEnabled")]
        public bool? ImplicitFlowEnabled { get; set; }
        [JsonPropertyName("directAccessGrantsEnabled")]
        public bool? DirectAccessGrantsEnabled { get; set; }
        [JsonPropertyName("serviceAccountsEnabled")]
        public bool? ServiceAccountsEnabled { get; set; }
        [JsonPropertyName("publicClient")]
        public bool? PublicClient { get; set; }
        [JsonPropertyName("frontchannelLogout")]
        public bool? FrontChannelLogout { get; set; }
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }
        [JsonPropertyName("attributes")]
        public IDictionary<string, object> Attributes { get; set; }
        [JsonPropertyName("authenticationFlowBindingOverrides")]
        public IDictionary<string, object> AuthenticationFlowBindingOverrides { get; set; }
        [JsonPropertyName("fullScopeAllowed")]
        public bool? FullScopeAllowed { get; set; }
        [JsonPropertyName("nodeReRegistrationTimeout")]
        public int? NodeReregistrationTimeout { get; set; }
        [JsonPropertyName("protocolMappers")]
        public IEnumerable<ClientProtocolMapper> ProtocolMappers { get; set; }
        [JsonPropertyName("defaultClientScopes")]
        public IEnumerable<string> DefaultClientScopes { get; set; }
        [JsonPropertyName("optionalClientScopes")]
        public IEnumerable<string> OptionalClientScopes { get; set; }
        [JsonPropertyName("access")]
        public ClientAccess Access { get; set; }
        [JsonPropertyName("secret")]
        public string Secret { get; set; }
        [JsonPropertyName("authorizationServicesEnabled")]
        public bool? AuthorizationServicesEnabled { get; set; }
    }
}
