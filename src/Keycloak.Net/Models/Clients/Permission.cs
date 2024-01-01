namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Permission : Resource
    {
        [JsonPropertyName("claims")]
        public IDictionary<string, object> Claims { get; set; }
    }
}

