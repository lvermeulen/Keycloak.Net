namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class OperationalInfo
    {
        [JsonPropertyName("databaseUrl")]
        public string DatabaseUrl { get; set; }

        [JsonPropertyName("databaseUser")]
        public string DatabaseUser { get; set; }

        [JsonPropertyName("databaseProduct")]
        public string DatabaseProduct { get; set; }

        [JsonPropertyName("databaseDriver")]
        public string DatabaseDriver { get; set; }
    }
}
