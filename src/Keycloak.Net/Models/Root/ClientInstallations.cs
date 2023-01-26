namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ClientInstallations
    {
        [JsonProperty("docker-v2")]
        public List<ClientInstallation> DockerV2 { get; set; }

        [JsonProperty("saml")]
        public List<ClientInstallation> Saml { get; set; }

        [JsonProperty("openid-connect")]
        public List<ClientInstallation> OpenIdConnect { get; set; }
    }
}