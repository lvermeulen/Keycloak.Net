using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class ClientPolicy : Policy
    {
        /// <summary>
        /// The ids of the clients. 
        /// </summary>
        [JsonProperty("clients")]
        public IEnumerable<string> Clients { get; set; }
    }
}