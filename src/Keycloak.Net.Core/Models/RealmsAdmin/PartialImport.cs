using System.Collections.Generic;
using Keycloak.Net.Common.Converters;
using Keycloak.Net.Models.Clients;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Users;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class PartialImport
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<IdentityProvider> IdentityProviders { get; set; }
        public string IfResourceExists { get; set; }
        [JsonConverter(typeof(PoliciesConverter))]
        public Policies Policy { get; set; }
        public Roles Roles { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
