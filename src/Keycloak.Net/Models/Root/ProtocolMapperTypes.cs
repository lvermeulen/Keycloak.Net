namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ProtocolMapperTypes
    {
        [JsonProperty("saml")]
        public List<ProtocolMapperType> Saml { get; set; }

        [JsonProperty("docker-v2")]
        public List<ProtocolMapperType> DockerV2 { get; set; }

        [JsonProperty("openid-connect")]
        public List<ProtocolMapperType> OpenIdConnect { get; set; }
    }
}