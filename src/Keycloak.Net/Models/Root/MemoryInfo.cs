using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class MemoryInfo
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("totalFormated")]
        public string TotalFormatted { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("usedFormated")]
        public string UsedFormatted { get; set; }

        [JsonProperty("free")]
        public long Free { get; set; }

        [JsonProperty("freePercentage")]
        public long FreePercentage { get; set; }

        [JsonProperty("freeFormated")]
        public string FreeFormatted { get; set; }
    }
}