using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class Permission : Resource
    {
        [JsonProperty("claims")]
        public IDictionary<string, object> Claims { get; set; }
    }
}
