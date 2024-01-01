namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Roles;
    using System.Text.Json.Serialization;

    public class Roles
    {
        [JsonPropertyName("client")]
        public IDictionary<string, object> Client { get; set; }
        [JsonPropertyName("realm")]
        public IEnumerable<Role> Realm { get; set; }
    }
}

