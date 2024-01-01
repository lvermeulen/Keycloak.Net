namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(NameConverter))]
    public enum Name
    {
        Base, 
        Keycloak, 
        RhSso
    }
}
