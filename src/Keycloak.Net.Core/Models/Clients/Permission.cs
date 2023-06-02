using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Clients
{
    public class Permission : Resource
    {
        [JsonProperty("claims")]
        public IDictionary<string, object> Claims { get; set; }
    }
}
