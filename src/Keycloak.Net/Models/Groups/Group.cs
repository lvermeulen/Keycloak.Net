using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Groups
{
    public class Group
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, string[]> Attributes { get; set; }
        [JsonProperty("realmRoles")]
        public string[] RealmRoles { get; set; }
        [JsonProperty("clientRoles")]
        public Dictionary<string, string[]> ClientRoles { get; set; }
        [JsonProperty("subGroups")]
        public Group[] SubGroups { get; private set; }
    }
}
