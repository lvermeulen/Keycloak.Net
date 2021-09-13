using System.Collections.Generic;
using Keycloak.Net.Common.Converters;
using Keycloak.Net.Models.AuthorizationPermissions;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class RolePolicy : Policy
    {
        [JsonConverter(typeof(PolicyTypeConverter))]
        public new PolicyType Type { get; set; } = PolicyType.Role;

        [JsonProperty("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
        
        [JsonProperty("config")]
        public PolicyConfig Config { get; set; }
    }

    public class RoleConfig
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }

    public class PolicyConfig
    {
        [JsonProperty("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
    }
}