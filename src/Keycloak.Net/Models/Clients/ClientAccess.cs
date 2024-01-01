namespace Keycloak.Net.Models.Clients
{
    using System.Text.Json.Serialization;

    public class ClientAccess
    {
        [JsonPropertyName("view")]
        public bool? View { get; set; }
        [JsonPropertyName("configure")]
        public bool? Configure { get; set; }
        [JsonPropertyName("manage")]
        public bool? Manage { get; set; }
    }
}
