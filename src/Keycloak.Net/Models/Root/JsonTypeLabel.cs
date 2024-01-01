namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonTypeLabelConverter))]
    public enum JsonTypeLabel
    {
        Boolean, 
        ClientList, 
        File, 
        List, 
        MultivaluedList, 
        MultivaluedString, 
        Password, 
        Role, 
        Script, 
        String, 
        Text
    }
}
