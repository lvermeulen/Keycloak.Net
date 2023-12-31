namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class HasOrder
    {
        [JsonProperty("order")]
        public long Order { get; set; }
    }
}