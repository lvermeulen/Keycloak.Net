using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Users
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("createdTimestamp")]
        public long CreatedTimestamp { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("totp")]
        public bool? Totp { get; set; }
        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("disableableCredentialTypes")]
        public ReadOnlyCollection<string> DisableableCredentialTypes { get; set; }
        [JsonProperty("requiredActions")]
        public ReadOnlyCollection<string> RequiredActions { get; set; }
        [JsonProperty("notBefore")]
        public int? NotBefore { get; set; }
        [JsonProperty("access")]
        public UserAccess Access { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, IEnumerable<string>> Attributes { get; set; }
        [JsonProperty("clientConsents")]
        public IEnumerable<UserConsent> ClientConsents { get; set; }
        [JsonProperty("clientRoles")]
        public IDictionary<string, object> ClientRoles { get; set; }
        [JsonProperty("credentials")]
        public IEnumerable<Credentials> Credentials { get; set; }
        [JsonProperty("federatedIdentities")]
        public IEnumerable<FederatedIdentity> FederatedIdentities { get; set; }
        [JsonProperty("federationLink")]
        public string FederationLink { get; set; }
        [JsonProperty("groups")]
        public IEnumerable<string> Groups { get; set; }
        [JsonProperty("origin")]
        public string Origin { get; set; }
        [JsonProperty("realmRoles")]
        public IEnumerable<string> RealmRoles { get; set; }
        [JsonProperty("self")]
        public string Self { get; set; }
        [JsonProperty("serviceAccountClientId")]
        public string ServiceAccountClientId { get; set; }
    }
}
