namespace Keycloak.Net.Models.Components
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Config
    {
        [JsonPropertyName("priority")]
        public IEnumerable<string> Priority { get; set; }
        [JsonPropertyName("allowdefaultscopes")]
        public IEnumerable<string> AllowDefaultScopes { get; set; }
        [JsonPropertyName("maxclients")]
        public IEnumerable<string> MaxClients { get; set; }
        [JsonPropertyName("allowedprotocolmappertypes")]
        public IEnumerable<string> AllowedProtocolMapperTypes { get; set; }
        [JsonPropertyName("algorithm")]
        public IEnumerable<string> Algorithm { get; set; }
        [JsonPropertyName("hostsendingregistrationrequestmustmatch")]
        public IEnumerable<string> HostSendingRegistrationRequestMustMatch { get; set; }
        [JsonPropertyName("clienturismustmatch")]
        public IEnumerable<string> ClientUrisMustMatch { get; set; }
    }
}
