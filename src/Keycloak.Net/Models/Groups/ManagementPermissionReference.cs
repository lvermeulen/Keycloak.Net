using Newtonsoft.Json;

namespace Keycloak.Net.Models.Groups
{
    public class ManagementPermissionReference
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
