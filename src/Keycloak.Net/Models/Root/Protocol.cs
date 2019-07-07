using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(ProtocolConverter))]
    public enum Protocol
    {
        DockerV2, 
        OpenIdConnect, 
        Saml
    }
}