using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class ClientPolicy : Policy
    {
        [JsonProperty("clients")]
        public IEnumerable<string> Clients { get; set; }
    }
}