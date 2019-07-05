using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Users
{
    public class UserSession
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty("start")]
        public long Start { get; set; }
        [JsonProperty("lastAccess")]
        public long LastAccess { get; set; }
        [JsonProperty("clients")]
        public IDictionary<string, string> Clients { get; set; }
    }
}
