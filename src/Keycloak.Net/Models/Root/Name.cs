namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(NameConverter))]
    public enum Name
    {
        Base, 
        Keycloak, 
        RhSso
    }
}