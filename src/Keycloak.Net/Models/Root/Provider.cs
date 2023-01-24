namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Provider
    {
        [JsonProperty("groupName")]
        public GroupName GroupName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}