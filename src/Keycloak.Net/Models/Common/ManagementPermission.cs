namespace Keycloak.Net.Models.Common
{
    using Newtonsoft.Json;

    public class ManagementPermission
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
