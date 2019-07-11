using Newtonsoft.Json;

namespace Keycloak.Net.Common
{
    public class ManagementPermission
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
