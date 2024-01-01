namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class SystemInfo
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("serverTime")]
        public string ServerTime { get; set; }

        [JsonPropertyName("uptime")]
        public string Uptime { get; set; }

        [JsonPropertyName("uptimeMillis")]
        public long UptimeMillis { get; set; }

        [JsonPropertyName("javaVersion")]
        public string JavaVersion { get; set; }

        [JsonPropertyName("javaVendor")]
        public string JavaVendor { get; set; }

        [JsonPropertyName("javaVm")]
        public string JavaVm { get; set; }

        [JsonPropertyName("javaVmVersion")]
        public string JavaVmVersion { get; set; }

        [JsonPropertyName("javaRuntime")]
        public string JavaRuntime { get; set; }

        [JsonPropertyName("javaHome")]
        public string JavaHome { get; set; }

        [JsonPropertyName("osName")]
        public string OsName { get; set; }

        [JsonPropertyName("osArchitecture")]
        public string OsArchitecture { get; set; }

        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }

        [JsonPropertyName("fileEncoding")]
        public string FileEncoding { get; set; }

        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("userDir")]
        public string UserDir { get; set; }

        [JsonPropertyName("userTimezone")]
        public string UserTimezone { get; set; }

        [JsonPropertyName("userLocale")]
        public string UserLocale { get; set; }
    }
}
