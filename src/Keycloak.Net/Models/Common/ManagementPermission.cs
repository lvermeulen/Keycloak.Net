namespace Keycloak.Net.Models.Common
{
    using System.Text.Json.Serialization;

    public class ManagementPermission
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}

