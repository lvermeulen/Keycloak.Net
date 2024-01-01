namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Text.Json.Serialization;

    public class Attributes
    {
        [JsonPropertyName("_browser_headerxXSSProtection")]
        public string BrowserHeaderxXssProtection { get; set; }
        [JsonPropertyName("_browser_headerxFrameOptions")]
        public string BrowserHeaderxFrameOptions { get; set; }
        [JsonPropertyName("_browser_headerstrictTransportSecurity")]
        public string BrowserHeaderstrictTransportSecurity { get; set; }
        [JsonPropertyName("permanentLockout")]
        public string PermanentLockout { get; set; }
        [JsonPropertyName("quickLoginCheckMilliSeconds")]
        public string QuickLoginCheckMilliSeconds { get; set; }
        [JsonPropertyName("_browser_headerxRobotsTag")]
        public string BrowserHeaderxRobotsTag { get; set; }
        [JsonPropertyName("maxFailureWaitSeconds")]
        public string MaxFailureWaitSeconds { get; set; }
        [JsonPropertyName("minimumQuickLoginWaitSeconds")]
        public string MinimumQuickLoginWaitSeconds { get; set; }
        [JsonPropertyName("failureFactor")]
        public string FailureFactor { get; set; }
        [JsonPropertyName("actionTokenGeneratedByUserLifespan")]
        public string ActionTokenGeneratedByUserLifespan { get; set; }
        [JsonPropertyName("maxDeltaTimeSeconds")]
        public string MaxDeltaTimeSeconds { get; set; }
        [JsonPropertyName("_browser_headerxContentTypeOptions")]
        public string BrowserHeaderxContentTypeOptions { get; set; }
        [JsonPropertyName("offlineSessionMaxLifespan")]
        public string OfflineSessionMaxLifespan { get; set; }
        [JsonPropertyName("actionTokenGeneratedByAdminLifespan")]
        public string ActionTokenGeneratedByAdminLifespan { get; set; }
        [JsonPropertyName("_browser_headercontentSecurityPolicyReportOnly")]
        public string BrowserHeadercontentSecurityPolicyReportOnly { get; set; }
        [JsonPropertyName("bruteForceProtected")]
        public string BruteForceProtected { get; set; }
        [JsonPropertyName("_browser_headercontentSecurityPolicy")]
        public string BrowserHeadercontentSecurityPolicy { get; set; }
        [JsonPropertyName("waitIncrementSeconds")]
        public string WaitIncrementSeconds { get; set; }
        [JsonPropertyName("offlineSessionMaxLifespanEnabled")]
        public string OfflineSessionMaxLifespanEnabled { get; set; }
    }
}
