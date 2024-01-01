namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AccessTokenAuthorization
    {
        [JsonPropertyName("permissions")]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}

