using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class ClientAccess
    {
        [JsonProperty("view")]
        public bool? View { get; set; }
        [JsonProperty("configure")]
        public bool? Configure { get; set; }
        [JsonProperty("manage")]
        public bool? Manage { get; set; }
    }
}