using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakStorageLdapMappersLdapStorageMapper
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("properties")]
        public List<KeycloakAuthenticationFormActionProperty> Properties { get; set; }

        [JsonProperty("metadata")]
        public KeycloakStorageLdapMappersLdapStorageMapperMetadata Metadata { get; set; }
    }
}