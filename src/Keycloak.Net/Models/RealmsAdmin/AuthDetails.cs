﻿namespace Keycloak.Net.Models.RealmsAdmin
{
    using Newtonsoft.Json;

    public class AuthDetails
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty("realmId")]
        public string RealmId { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
