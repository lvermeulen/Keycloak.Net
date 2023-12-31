namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(ProtocolConverter))]
    public enum Protocol
    {
        DockerV2, 
        OpenIdConnect, 
        Saml
    }
}