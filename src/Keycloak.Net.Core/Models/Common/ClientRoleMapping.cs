using Keycloak.Net.Models.Roles;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Common
{
    public class ClientRoleMapping
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
        [JsonProperty("mappings")]
        public List<Role> Mappings { get; set; }
    }
}
