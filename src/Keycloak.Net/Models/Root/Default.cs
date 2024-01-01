namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Default
    {
        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("operationalInfo")]
        public OperationalInfo OperationalInfo { get; set; }
    }
}
