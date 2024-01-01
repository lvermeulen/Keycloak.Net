namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AccessTokenAccess
    {
        [JsonPropertyName("roles")] 
        public IEnumerable<string> Roles  { get; set; }
        [JsonPropertyName("verify_caller")] 
        public bool? VerifyCaller { get; set; }
    }
}
