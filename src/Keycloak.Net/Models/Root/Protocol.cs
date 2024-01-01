namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(ProtocolConverter))]
    public enum Protocol
    {
        DockerV2, 
        OpenIdConnect, 
        Saml
    }
}
