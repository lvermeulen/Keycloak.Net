using Newtonsoft.Json;
using System.Collections.Generic;

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