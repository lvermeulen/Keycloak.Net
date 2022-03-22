using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeycloakStorageUserStorageProviderMetadata
    {
        [JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }
    }
}