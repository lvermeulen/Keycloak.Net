using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class BrowserSecurityHeaders
    {
        [JsonProperty("contentSecurityPolicyReportOnly")]
        public string ContentSecurityPolicyReportOnly { get; set; }
        [JsonProperty("xContentTypeOptions")]
        public string XContentTypeOptions { get; set; }
        [JsonProperty("xRobotsTag")]
        public string XRobotsTag { get; set; }
        [JsonProperty("xFrameOptions")]
        public string XFrameOptions { get; set; }
        [JsonProperty("xXSSProtection")]
        public string XXssProtection { get; set; }
        [JsonProperty("contentSecurityPolicy")]
        public string ContentSecurityPolicy { get; set; }
        [JsonProperty("strictTransportSecurity")]
        public string StrictTransportSecurity { get; set; }
    }
}