using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Clients
{
    public class AccessTokenAccess
    {
        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }
        [JsonProperty("verify_caller")]
        public bool? VerifyCaller { get; set; }
    }
}
