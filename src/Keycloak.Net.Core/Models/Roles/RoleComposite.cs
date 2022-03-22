using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Roles
{
    public class RoleComposite
    {
        [JsonProperty("client")]        
        public IDictionary<string, string> Client { get; set; }
        [JsonProperty("realm")]
        public IEnumerable<string> Realm { get; set; }
    }
}