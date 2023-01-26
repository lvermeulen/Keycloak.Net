namespace Keycloak.Net.Models.Root
{
    using Keycloak.Net.Common.Converters;
    using Newtonsoft.Json;

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