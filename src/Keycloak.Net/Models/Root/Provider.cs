namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Provider
    {
        [JsonPropertyName("groupName")]
        public GroupName GroupName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
