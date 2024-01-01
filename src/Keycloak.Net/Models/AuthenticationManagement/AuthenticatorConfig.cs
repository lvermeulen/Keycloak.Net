namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthenticatorConfig
    {
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        [JsonPropertyName("config")]
        public IDictionary<string, object> Config { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
