namespace Keycloak.Net.Models.Components
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Config
    {
        [JsonProperty("priority")]
        public IEnumerable<string> Priority { get; set; }
        [JsonProperty("allowdefaultscopes")]
        public IEnumerable<string> AllowDefaultScopes { get; set; }
        [JsonProperty("maxclients")]
        public IEnumerable<string> MaxClients { get; set; }
        [JsonProperty("allowedprotocolmappertypes")]
        public IEnumerable<string> AllowedProtocolMapperTypes { get; set; }
        [JsonProperty("algorithm")]
        public IEnumerable<string> Algorithm { get; set; }
        [JsonProperty("hostsendingregistrationrequestmustmatch")]
        public IEnumerable<string> HostSendingRegistrationRequestMustMatch { get; set; }
        [JsonProperty("clienturismustmatch")]
        public IEnumerable<string> ClientUrisMustMatch { get; set; }
    }
}