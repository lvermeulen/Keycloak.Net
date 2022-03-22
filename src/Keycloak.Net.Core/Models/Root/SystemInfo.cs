using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class SystemInfo
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("serverTime")]
        public string ServerTime { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }

        [JsonProperty("uptimeMillis")]
        public long UptimeMillis { get; set; }

        [JsonProperty("javaVersion")]
        public string JavaVersion { get; set; }

        [JsonProperty("javaVendor")]
        public string JavaVendor { get; set; }

        [JsonProperty("javaVm")]
        public string JavaVm { get; set; }

        [JsonProperty("javaVmVersion")]
        public string JavaVmVersion { get; set; }

        [JsonProperty("javaRuntime")]
        public string JavaRuntime { get; set; }

        [JsonProperty("javaHome")]
        public string JavaHome { get; set; }

        [JsonProperty("osName")]
        public string OsName { get; set; }

        [JsonProperty("osArchitecture")]
        public string OsArchitecture { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("fileEncoding")]
        public string FileEncoding { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userDir")]
        public string UserDir { get; set; }

        [JsonProperty("userTimezone")]
        public string UserTimezone { get; set; }

        [JsonProperty("userLocale")]
        public string UserLocale { get; set; }
    }
}