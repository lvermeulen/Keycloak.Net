namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class LdapMapper
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public LdapMapperProviders Providers { get; set; }
    }
}
