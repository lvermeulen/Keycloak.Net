using Keycloak.Net.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakStorageLdapMappersLdapStorageMapper
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<ConfigProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public KeycloakStorageLdapMappersLdapStorageMapperMetadata Metadata { get; set; }
    }
}