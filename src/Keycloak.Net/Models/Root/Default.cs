namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Default
    {
        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("operationalInfo")]
        public OperationalInfo OperationalInfo { get; set; }
    }
}