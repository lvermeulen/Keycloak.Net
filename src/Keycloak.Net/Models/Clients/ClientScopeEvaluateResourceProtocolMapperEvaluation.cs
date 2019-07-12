using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class ClientScopeEvaluateResourceProtocolMapperEvaluation
    {
        [JsonProperty("containerId")]
        public string ContainerId { get; set; }
        [JsonProperty("containerName")]
        public string ContainerName { get; set; }
        [JsonProperty("containerType")]
        public string ContainerType { get; set; }
        [JsonProperty("mapperId")]
        public string MapperId { get; set; }
        [JsonProperty("mapperName")]
        public string MapperName { get; set; }
        [JsonProperty("protocolMapper")]
        public string ProtocolMapper { get; set; }
    }
}
