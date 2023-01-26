namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthenticatorConfig
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("config")]
        public IDictionary<string, object> Config { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
