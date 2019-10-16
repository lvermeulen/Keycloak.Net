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
        public Dictionary<string, string> Attributes { get; set; }
    }
}
