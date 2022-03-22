using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class Attributes
    {
        [JsonProperty("_browser_headerxXSSProtection")]
        public string BrowserHeaderxXssProtection { get; set; }
        [JsonProperty("_browser_headerxFrameOptions")]
        public string BrowserHeaderxFrameOptions { get; set; }
        [JsonProperty("_browser_headerstrictTransportSecurity")]
        public string BrowserHeaderstrictTransportSecurity { get; set; }
        [JsonProperty("permanentLockout")]
        public string PermanentLockout { get; set; }
        [JsonProperty("quickLoginCheckMilliSeconds")]
        public string QuickLoginCheckMilliSeconds { get; set; }
        [JsonProperty("_browser_headerxRobotsTag")]
        public string BrowserHeaderxRobotsTag { get; set; }
        [JsonProperty("maxFailureWaitSeconds")]
        public string MaxFailureWaitSeconds { get; set; }
        [JsonProperty("minimumQuickLoginWaitSeconds")]
        public string MinimumQuickLoginWaitSeconds { get; set; }
        [JsonProperty("failureFactor")]
        public string FailureFactor { get; set; }
        [JsonProperty("actionTokenGeneratedByUserLifespan")]
        public string ActionTokenGeneratedByUserLifespan { get; set; }
        [JsonProperty("maxDeltaTimeSeconds")]
        public string MaxDeltaTimeSeconds { get; set; }
        [JsonProperty("_browser_headerxContentTypeOptions")]
        public string BrowserHeaderxContentTypeOptions { get; set; }
        [JsonProperty("offlineSessionMaxLifespan")]
        public string OfflineSessionMaxLifespan { get; set; }
        [JsonProperty("actionTokenGeneratedByAdminLifespan")]
        public string ActionTokenGeneratedByAdminLifespan { get; set; }
        [JsonProperty("_browser_headercontentSecurityPolicyReportOnly")]
        public string BrowserHeadercontentSecurityPolicyReportOnly { get; set; }
        [JsonProperty("bruteForceProtected")]
        public string BruteForceProtected { get; set; }
        [JsonProperty("_browser_headercontentSecurityPolicy")]
        public string BrowserHeadercontentSecurityPolicy { get; set; }
        [JsonProperty("waitIncrementSeconds")]
        public string WaitIncrementSeconds { get; set; }
        [JsonProperty("offlineSessionMaxLifespanEnabled")]
        public string OfflineSessionMaxLifespanEnabled { get; set; }
    }
}