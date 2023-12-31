namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Permission : Resource
    {
        [JsonProperty("claims")]
        public IDictionary<string, object> Claims { get; set; }
    }
}
