using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class GlobalRequestResult
    {
        [JsonProperty("failedRequests")]
        public IEnumerable<string> FailedRequests { get; set; }
        [JsonProperty("successRequests")]
        public IEnumerable<string> SuccessRequests { get; set; }
    }
}
