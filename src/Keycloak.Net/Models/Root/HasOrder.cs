using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class HasOrder
    {
        [JsonProperty("order")]
        public long Order { get; set; }
    }
}