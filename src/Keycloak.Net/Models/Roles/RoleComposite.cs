namespace Keycloak.Net.Models.Roles
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RoleComposite
    {
        [JsonPropertyName("client")]        
        public IDictionary<string, string> Client { get; set; }
        [JsonPropertyName("realm")]
        public IEnumerable<string> Realm { get; set; }
    }
}
