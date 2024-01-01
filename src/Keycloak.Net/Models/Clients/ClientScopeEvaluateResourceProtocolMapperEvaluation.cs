namespace Keycloak.Net.Models.Clients
{
    using System.Text.Json.Serialization;

    public class ClientScopeEvaluateResourceProtocolMapperEvaluation
    {
        [JsonPropertyName("containerId")]
        public string ContainerId { get; set; }
        [JsonPropertyName("containerName")]
        public string ContainerName { get; set; }
        [JsonPropertyName("containerType")]
        public string ContainerType { get; set; }
        [JsonPropertyName("mapperId")]
        public string MapperId { get; set; }
        [JsonPropertyName("mapperName")]
        public string MapperName { get; set; }
        [JsonPropertyName("protocolMapper")]
        public string ProtocolMapper { get; set; }
    }
}

