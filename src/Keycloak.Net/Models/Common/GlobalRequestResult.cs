namespace Keycloak.Net.Models.Common
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class GlobalRequestResult
    {
        [JsonProperty("failedRequests")]
        public IEnumerable<string> FailedRequests { get; set; }
        [JsonProperty("successRequests")]
        public IEnumerable<string> SuccessRequests { get; set; }
    }
}
