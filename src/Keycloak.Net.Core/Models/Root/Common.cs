using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Common
    {
        [JsonProperty("name")]
        public Name Name { get; set; }
    }
}