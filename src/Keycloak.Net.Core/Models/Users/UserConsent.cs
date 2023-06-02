using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Users
{
    public class UserConsent
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("grantedClientScopes")]
        public IEnumerable<string> GrantedClientScopes { get; set; }
        [JsonProperty("createdDate")]
        public long? CreatedDate { get; set; }
        [JsonProperty("lastUpdatedDate")]
        public long? LastUpdatedDate { get; set; }
    }
}
