using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Roles
{
    public class Role
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("composite")]
        public bool? Composite { get; set; }
        [JsonProperty("clientRole")]
        public bool? ClientRole { get; set; }
        [JsonProperty("containerId")]
        public string ContainerId { get; set; }
        [JsonProperty("attributes")]
        public IDictionary<string, string> Attributes { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
