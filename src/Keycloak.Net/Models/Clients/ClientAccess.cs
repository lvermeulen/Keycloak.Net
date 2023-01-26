namespace Keycloak.Net.Models.Clients
{
    using Newtonsoft.Json;

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