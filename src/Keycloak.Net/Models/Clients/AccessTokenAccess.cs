namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccessTokenAccess
    {
        [JsonProperty("roles")] 
        public IEnumerable<string> Roles  { get; set; }
        [JsonProperty("verify_caller")] 
        public bool? VerifyCaller { get; set; }
    }
}
