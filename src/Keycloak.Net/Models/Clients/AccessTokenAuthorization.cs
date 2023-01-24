namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccessTokenAuthorization
    {
        [JsonProperty("permissions")]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
