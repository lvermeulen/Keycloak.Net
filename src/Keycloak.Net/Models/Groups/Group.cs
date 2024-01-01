namespace Keycloak.Net.Models.Groups
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Group
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("path")]
        public string Path { get; set; }
        [JsonPropertyName("subGroups")]
        public IEnumerable<Group> Subgroups { get; set; }
        [JsonPropertyName("realmRoles")]
        public IEnumerable<string> RealmRoles { get; set; }
        [JsonPropertyName("clientRoles")]
        public IDictionary<string, IEnumerable<string>> ClientRoles { get; set; }
        [JsonPropertyName("attributes")]
        public IDictionary<string, IEnumerable<string>> Attributes { get; set; }
    }
}

