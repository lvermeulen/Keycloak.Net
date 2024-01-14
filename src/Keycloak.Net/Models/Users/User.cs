namespace Keycloak.Net.Models.Users
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text.Json.Serialization;

    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("createdTimestamp")]
        public long CreatedTimestamp { get; set; }
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        [JsonPropertyName("totp")]
        public bool? Totp { get; set; }
        [JsonPropertyName("emailVerified")]
        public bool? EmailVerified { get; set; }
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("disableableCredentialTypes")]
        public List<string> DisableableCredentialTypes { get; set; }
        [JsonPropertyName("requiredActions")]
        public List<string> RequiredActions { get; set; }
        [JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }
        [JsonPropertyName("access")]
        public UserAccess Access { get; set; }
        [JsonPropertyName("attributes")]
        public Dictionary<string, IEnumerable<string>> Attributes { get; set; }
        [JsonPropertyName("clientConsents")]
        public IEnumerable<UserConsent> ClientConsents { get; set; }
        [JsonPropertyName("clientRoles")]
        public IDictionary<string, object> ClientRoles { get; set; }
        [JsonPropertyName("credentials")]
        public IEnumerable<Credentials> Credentials { get; set; }
        [JsonPropertyName("federatedIdentities")]
        public IEnumerable<FederatedIdentity> FederatedIdentities { get; set; }
        [JsonPropertyName("federationLink")]
        public string FederationLink { get; set; }
        [JsonPropertyName("groups")]
        public IEnumerable<string> Groups { get; set; }
        [JsonPropertyName("origin")]
        public string Origin { get; set; }
        [JsonPropertyName("realmRoles")]
        public IEnumerable<string> RealmRoles { get; set; }
        [JsonPropertyName("self")]
        public string Self { get; set; }
        [JsonPropertyName("serviceAccountClientId")]
        public string ServiceAccountClientId { get; set; }
    }
}

