namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Collections.Generic;
    using Keycloak.Net.Common.Converters;
    using Clients;
    using Groups;
    using Users;
    using Newtonsoft.Json;

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
