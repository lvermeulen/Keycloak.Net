using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class OperationalInfo
    {
        [JsonProperty("databaseUrl")]
        public string DatabaseUrl { get; set; }

        [JsonProperty("databaseUser")]
        public string DatabaseUser { get; set; }

        [JsonProperty("databaseProduct")]
        public string DatabaseProduct { get; set; }

        [JsonProperty("databaseDriver")]
        public string DatabaseDriver { get; set; }
    }
}