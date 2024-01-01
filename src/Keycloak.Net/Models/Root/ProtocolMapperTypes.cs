namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ProtocolMapperTypes
    {
        [JsonPropertyName("saml")]
        public List<ProtocolMapperType> Saml { get; set; }

        [JsonPropertyName("docker-v2")]
        public List<ProtocolMapperType> DockerV2 { get; set; }

        [JsonPropertyName("openid-connect")]
        public List<ProtocolMapperType> OpenIdConnect { get; set; }
    }
}
