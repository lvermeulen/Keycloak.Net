namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class LdapMapper
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public LdapMapperProviders Providers { get; set; }
    }
}