namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Common
    {
        [JsonProperty("name")]
        public Name Name { get; set; }
    }
}