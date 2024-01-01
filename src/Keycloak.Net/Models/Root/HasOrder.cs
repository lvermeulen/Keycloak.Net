namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class HasOrder
    {
        [JsonPropertyName("order")]
        public long Order { get; set; }
    }
}
