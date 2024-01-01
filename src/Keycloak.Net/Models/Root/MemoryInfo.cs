namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class MemoryInfo
    {
        [JsonPropertyName("total")]
        public long Total { get; set; }

        [JsonPropertyName("totalFormated")]
        public string TotalFormatted { get; set; }

        [JsonPropertyName("used")]
        public long Used { get; set; }

        [JsonPropertyName("usedFormated")]
        public string UsedFormatted { get; set; }

        [JsonPropertyName("free")]
        public long Free { get; set; }

        [JsonPropertyName("freePercentage")]
        public long FreePercentage { get; set; }

        [JsonPropertyName("freeFormated")]
        public string FreeFormatted { get; set; }
    }
}
