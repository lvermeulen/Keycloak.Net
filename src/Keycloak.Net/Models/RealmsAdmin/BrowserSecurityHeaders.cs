namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Text.Json.Serialization;

    public class BrowserSecurityHeaders
    {
        [JsonPropertyName("contentSecurityPolicyReportOnly")]
        public string ContentSecurityPolicyReportOnly { get; set; }
        [JsonPropertyName("xContentTypeOptions")]
        public string XContentTypeOptions { get; set; }
        [JsonPropertyName("xRobotsTag")]
        public string XRobotsTag { get; set; }
        [JsonPropertyName("xFrameOptions")]
        public string XFrameOptions { get; set; }
        [JsonPropertyName("xXSSProtection")]
        public string XXssProtection { get; set; }
        [JsonPropertyName("contentSecurityPolicy")]
        public string ContentSecurityPolicy { get; set; }
        [JsonPropertyName("strictTransportSecurity")]
        public string StrictTransportSecurity { get; set; }
    }
}
