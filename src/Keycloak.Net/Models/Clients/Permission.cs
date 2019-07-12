using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class Permission
    {
        [JsonProperty("claims")]
        public IDictionary<string, object> Claims { get; set; }
        [JsonProperty("rsid")]
        public string RsId { get; set; }
        [JsonProperty("rsname")]
        public string RsName { get; set; }
        [JsonProperty("scopes")]
        public string Scopes { get; set; }
    }
}
