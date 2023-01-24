namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class KeycloakStorageLdapMappersLdapStorageMapperMetadata
    {
        [JsonProperty("fedToKeycloakSyncSupported")]
        public bool? FedToKeycloakSyncSupported { get; set; }

        [JsonProperty("keycloakToFedSyncSupported")]
        public bool? KeycloakToFedSyncSupported { get; set; }

        [JsonProperty("fedToKeycloakSyncMessage")]
        public string FedToKeycloakSyncMessage { get; set; }

        [JsonProperty("keycloakToFedSyncMessage")]
        public string KeycloakToFedSyncMessage { get; set; }
    }
}