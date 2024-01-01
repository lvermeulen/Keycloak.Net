namespace Keycloak.Net.Models.Common
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class GlobalRequestResult
    {
        [JsonPropertyName("failedRequests")]
        public IEnumerable<string> FailedRequests { get; set; }
        [JsonPropertyName("successRequests")]
        public IEnumerable<string> SuccessRequests { get; set; }
    }
}

