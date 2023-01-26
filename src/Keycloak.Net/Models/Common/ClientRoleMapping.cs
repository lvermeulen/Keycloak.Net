namespace Keycloak.Net.Models.Common
{
    using Roles;
    using Newtonsoft.Json;
    using System.Collections.Generic;

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
